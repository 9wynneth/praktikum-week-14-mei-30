using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum_week_14_mei_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtTeamDetail3Teratas = new DataTable();
        DataTable dtTeamDetailTopScorer = new DataTable();
        DataTable dtTeamDetailWorstDiscipline = new DataTable();
        DataTable dtDGVmatch = new DataTable();

        int posisiSekarang = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_name, Concat(m.manager_name, ' (', n.nation,')'), Concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')'), t.team_id FROM team t, manager m, nationality n WHERE t.manager_id = m.manager_id and m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamDetail3Teratas);


            DataTeamDetail(posisiSekarang);
           

        
        }

        public void DataTeamDetail(int DataKe)
        {
            lbl_teamName.Text = dtTeamDetail3Teratas.Rows[DataKe][0].ToString();
            lbl_manager.Text = dtTeamDetail3Teratas.Rows[DataKe][1].ToString();
            lbl_stadium.Text = dtTeamDetail3Teratas.Rows[DataKe][2].ToString();
            string teamID = dtTeamDetail3Teratas.Rows[DataKe][3].ToString();
            posisiSekarang = DataKe;

           
            dtTeamDetailTopScorer = new DataTable();
            sqlQuery = $"SELECT p.player_name,sum(if (d.`type`= 'GP' or d.`type`= 'GO',1,0)),sum(if (d.`type`= 'GP',1,0)) FROM player p, dmatch d, team t WHERE p.player_id = d.player_id and t.team_id=p.team_id and d.team_id=t.team_id and t.team_name ='{lbl_teamName.Text}' GROUP BY 1 ORDER BY 2 DESC; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamDetailTopScorer);
            lbl_topScorer.Text = $"{dtTeamDetailTopScorer.Rows[0][0].ToString()} {dtTeamDetailTopScorer.Rows[0][1].ToString()} ({dtTeamDetailTopScorer.Rows[0][2].ToString()})";


            dtTeamDetailWorstDiscipline = new DataTable();
            sqlQuery = "SELECT p.player_name, sum(if(dm.`type` = 'CY',1,0)), sum(if(dm.`type` = 'CR',1,0)), sum(if(dm.`type` = 'CY',1,0)) + sum(if(dm.`type` = 'CR',3,0)) FROM dmatch dm, team t, player p WHERE p.player_id = dm.player_id and p.team_id = t.team_id and t.team_name = '" + lbl_teamName.Text + "' GROUP BY 1 ORDER BY 4 DESC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamDetailWorstDiscipline);

            lbl_worstDiscipline.Text=$"{dtTeamDetailWorstDiscipline.Rows[0][0].ToString()}, {dtTeamDetailWorstDiscipline.Rows[0][1].ToString()} Yellow Card and {dtTeamDetailWorstDiscipline.Rows[0][2]} Red Card";

            dtDGVmatch = new DataTable();
            sqlQuery = $"SELECT date_format(m.match_date, '%d/%m/%Y') as 'match_date', if(m.team_home='{teamID}', 'HOME', 'AWAY') as 'Home/Away', concat('vs ',if(m.team_home='{teamID}', (select t.team_name from team t where t.team_id = m.team_away), (select t.team_name from team t where t.team_id = m.team_home)))as 'lawan', if (goal_home is null or goal_away is null, 'belum berlangsung', concat(m.goal_home, ' - ', m.goal_away))as 'score' FROM `match` m WHERE m.team_home = '{teamID}' or m.team_away = '{teamID}' ORDER BY m.match_date desc limit 5; "; 
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDGVmatch);
            dataGV_latestMatch.DataSource = dtDGVmatch;

        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            posisiSekarang = 0;
            DataTeamDetail(posisiSekarang);
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            posisiSekarang = dtTeamDetail3Teratas.Rows.Count - 1;
            DataTeamDetail(posisiSekarang);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (posisiSekarang > 0)
            {
                posisiSekarang--;
                DataTeamDetail(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (posisiSekarang < dtTeamDetail3Teratas.Rows.Count - 1)
            {
                posisiSekarang++;
                DataTeamDetail(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }
    }
}
