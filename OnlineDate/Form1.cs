using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;
using Newtonsoft.Json;
using System.Globalization;


namespace OnlineDate
{
    public partial class Form1 : Form
    {

        //pb = progressbar
        //  double pbUnit;
        //  int pbWIDTH, pbHIEGHT, pbComplete;

        //  Bitmap bmp;
        // Graphics g;
        const string APPID = "3875aad659034aa65665d9d0dadb548a";
        string cityName = "Port Elizabeth";
        
        public Form1()
        {
            InitializeComponent();
            getWeather("Port Elizabeth");
            getForcast("Port Elizabeth");
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0},za&appid={1}&units=metric&cnt=6",city, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                WeatherInfo.Root outPut = result;

                lblcityName.Text = string.Format("{0}", outPut.name);
                lblSouth.Text = string.Format("{0}", outPut.sys.country);
                lblnum.Text = string.Format("{0} \u00B0"+"C", outPut.main.temp);



            }

        }
        void getForcast(string city)
        {
            int day = 7;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0},ZA&units=metric&cnt={1}&appid={2}",city,day,APPID);
            using (WebClient web = new WebClient())
            {
               
                var json = web.DownloadString(url);

                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;

                //Nextday

                 lblDay1.Text = string.Format("{0}", forcast.list[1].dt);
                lblCondition1.Text = string.Format("{0}", forcast.list[1].weather[0].main);
                lblDescription1.Text = string.Format("{0}", forcast.list[1].weather[0].description);
                lbltemp1.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].temp);
                lblWindS1.Text = string.Format("{0} km/h", forcast.list[1].speed);

                //Tomorow

                lblDay2.Text = string.Format("{0}", forcast.list[2].dt);
                lblCondition2.Text = string.Format("{0}", forcast.list[2].weather[0].main);
                lblDescription2.Text = string.Format("{0}", forcast.list[2].weather[0].description);
                lbltemp_2.Text = string.Format("{0} \u00B0" + "C", forcast.list[2].temp);
                lblWindS2.Text = string.Format("{0} km/h", forcast.list[2].speed);

                //Third day
                lblDay3.Text = string.Format("{0}", forcast.list[3].dt);
                lblCondition3.Text = string.Format("{0}", forcast.list[3].weather[0].main);
                lblDescription3.Text = string.Format("{0}", forcast.list[3].weather[0].description);
                lbltemp_3.Text = string.Format("{0} \u00B0" + "C", forcast.list[3].temp);
                lblWindS3.Text = string.Format("{0} km/h", forcast.list[3].speed);

                //Fourth day

                lblDay4.Text = string.Format("{0}", forcast.list[4].dt);
                lblCondition4.Text = string.Format("{0}", forcast.list[4].weather[0].main);
                lblDescription4.Text = string.Format("{0}", forcast.list[4].weather[0].description);
                lbltemp_4.Text = string.Format("{0} \u00B0" + "C", forcast.list[4].temp);
                lblWindS4.Text = string.Format("{0} km/h", forcast.list[4].speed);

                //Firth
                lblDay5.Text = string.Format("{0}", forcast.list[5].dt);
                lblCondition5.Text = string.Format("{0}", forcast.list[5].weather[0].main);
                lblDescription5.Text = string.Format("{0}", forcast.list[5].weather[0].description);
                lbltemp_5.Text = string.Format("{0} \u00B0" + "C", forcast.list[5].temp);
                lblWindS5.Text = string.Format("{0} km/h", forcast.list[5].speed);

                //sixth
                lblDay6.Text = string.Format("{0}", forcast.list[6].dt);
                lblCondition6.Text = string.Format("{0}", forcast.list[6].weather[0].main);
                lblDescription6.Text = string.Format("{0}", forcast.list[6].weather[0].description);
                lbltemp_6.Text = string.Format("{0} \u00B0" + "C", forcast.list[6].temp);
                lblWindS6.Text = string.Format("{0} km/h", forcast.list[6].speed);




            }

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTimeOffset localTime = DateTimeOffset.Now;
            DateTimeOffset utcGlobal = DateTimeOffset.UtcNow;

            txtPC.Text = localTime.ToString("dd-mm-yyyy hh:mm:ss");
            txtLoc.Text = utcGlobal.ToString("dd-mm-yyyy hh:mm:ss");

            //graphics
          //  g = Graphics.FromImage(bmp);



            //clear graphics
           // g.Clear(Color.DarkGoldenrod);

            //draw progressbar
          //  g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHIEGHT));

            //draw % Complete
          //  g.DrawString(pbComplete + "%", new Font("Arial", pbHIEGHT / 2), Brushes.Black, new PointF(pbWIDTH / 2 - pbHIEGHT, pbHIEGHT / 10));

            // load bitmap in picturebox picboxPB
          //  ;

          //  pbComplete++;
          //  if (pbComplete > 100)
          //  {
                //dispose
            //    g.Dispose();
                
          //  }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtDifferece.Hide();
            lblDiff.Hide();
            // progressBar1.Hide();

          

            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();
                string todaysDates = response.Headers["date"];
                DateTime dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);

                txtLoc.Text = dateTime.ToString();
                response.Close();
            }
            catch
            {

            }

            DateTimeOffset localTime = DateTimeOffset.Now;
           // DateTimeOffset utcGlobal = DateTimeOffset.UtcNow;

            txtPC.Text = localTime.ToString("dd-mm-yyyy hh:mm:ss");
           // txtLoc.Text = utcGlobal.ToString("dd-mm-yyyy hh:mm:ss");
            txtDifferece.Text = localTime.Offset.ToString();
        }

        public void display(string text)
        {
            MessageBox.Show(text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //there should be no GUI component method

            for (int i = 0; i < 101; i++)
            {
               
                simulateHeavyWork();
                backgroundWorker1.ReportProgress(i);

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //recieve update after 100ms
            progressBar1.Value = e.ProgressPercentage;
            lblPercent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
                MessageBox.Show("Email Is Successfully Sent");
            
           
        }

        private void Check_Click(object sender, EventArgs e)
        {



            txtDifferece.Show();
            lblDiff.Show();
            // progressBar1.Show();

            string global = txtLoc.Text;
            string local = txtLoc.Text;
            string[] PCtime = local.Split(' ');
            string[] OnTime = global.Split(' ');

            string[] GYears = OnTime[0].Split('-');
            string[] GTimes = OnTime[1].Split(':');
            string Day, Month, Year, Min, Hrs, Secs;

            string[] PYear = PCtime[0].Split('-');
            string[] PTime = PCtime[1].Split(':');


            if (GYears[0] == PYear[0])
            {
                Day = "The days are the same";
            }
            else if (GYears[0] != PYear[0])
            {
                Day = "The difference is:" + GYears[0];
            }


            if (GYears[1] == PYear[1])
            {
                Month = "The days are the same";
            }
            else if (GYears[1] != PYear[1])
            {
                Month = "The difference is:" + GYears[1];
            }

            if (GTimes[2] == PTime[2])
            {
                Year = "The days are the same";
            }
            else if (GYears[2] != PYear[2])
            {
                Year = "The difference is:" + GYears[2];
            }

            if (GTimes[0] == PTime[0])
            {
                Hrs = "The days are the same";
            }
            else if (GTimes[0] != PTime[0])
            {
                Hrs = "The difference is:" + GTimes[0];
            }

            if (GTimes[1] == PTime[1])
            {
                Min = "The days are the same";
            }
            else if (GTimes[1] != PTime[1])
            {
                Min = "The difference is:" + GTimes[1];
            }

            if (GTimes[2] == PTime[2])
            {
                Secs = "The days are the same";
            }
            else if (GTimes[2] != PTime[2])
            {
                Secs = "The difference is:" + GTimes[2];
            }



            /*

            int maxitem = 0;
            maxitem = 100;
            progressBar1.Maximum = 100;
            progressBar1.Value += 0;
            for (int i = 0; i < maxitem; i++)
                progressBar1.Value += 1;
                */


            try
            {
                NetworkCredential login = new NetworkCredential("maqashuaa@gmail.com", "210078626aa");
                string smtpServer = "smtp.gmail.com";
                SmtpClient client = new SmtpClient(smtpServer);
                MailAddress from = new MailAddress("maqashuaa@email.com", "subject", System.Text.Encoding.UTF8);
                MailAddress to = new MailAddress("ayazpopcorn@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Body = txtDifferece.Text + txtLoc.Text;


                message.Body += Environment.NewLine;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Time Comparising";
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                client.Credentials = login;
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);

               // MessageBox.Show("Successfully Sent");
            }
            catch (Exception ax)
            {
                MessageBox.Show(ax.Message);
            }


            backgroundWorker1.RunWorkerAsync();

        }
        private void simulateHeavyWork()
        {
            Thread.Sleep(101);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Form1.Closed();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeOffset localTime = DateTimeOffset.Now;
            DateTimeOffset utcGlobal = DateTimeOffset.UtcNow;

            txtPC.Text = localTime.ToString("dd-mm-yyyy hh:mm:ss");
            txtLoc.Text = utcGlobal.ToString("dd-mm-yyyy hh:mm:ss");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
