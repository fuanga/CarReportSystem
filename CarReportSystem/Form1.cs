using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        
        BindingList<CarReport> carReports = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
           // dgvcardate.DataSource = carReports;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202029DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.carReportTableAdapter.Fill(this.infosys202029DataSet.CarReport);
            //dgvcardate.Columns[0].Visible = false; //idを非表示にする
        }




        private void btAdd_Click(object sender, EventArgs e)
        {
           
            #region
            /*var carreport = new CarReport
            {
                CreatedDate = dtpCreate.Value,
                Author = cbRecorder.Text,
                Maker = RadioCheck(),
                Name = cbName.Text,
                Report = tbReport.Text,
                Picture = pbImage.Image
            };

            carReports.Insert(0, carreport);
            */
            #endregion
            dgvcardate.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202029DataSet);
        }

        private CarReport.CarMaker RadioCheck()
        {
            CarReport.CarMaker check = CarReport.CarMaker.DEFAULT;

            if (rdbtoyota.Checked)
            {
                check = CarReport.CarMaker.トヨタ;
            }
            else if (rdbniisan.Checked)
            {
                check = CarReport.CarMaker.日産;
            }
            else if (rdbhonda.Checked)
            {
                check = CarReport.CarMaker.ホンダ;
            }
            else if (rdbsubaru.Checked)
            {
                check = CarReport.CarMaker.スバル;
            }
            else if (rdbgaisya.Checked)
            {
                check = CarReport.CarMaker.外車;
            }
            else if (rdboter.Checked)
            {
                check = CarReport.CarMaker.その他;
            }
            return check;
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            dgvcardate.CurrentRow.Cells[2].Value = cbAuthor.Text;

            //データベースに反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202029DataSet);


            // CarReport selectCarReport = carReports[dgvcardate.CurrentRow.Index];

            //selectCarReport.CreatedDate = dtpCreate.Value;
            //selectCarReport.Author = cbRecorder.Text;
            //selectCarReport.Maker = RadioCheck();
            //selectCarReport.Name = cbName.Text;
            //selectCarReport.Report = tbReport.Text;
            //selectCarReport.Picture = pbImage.Image;

            dgvcardate.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
            carReports.RemoveAt(dgvcardate.CurrentRow.Index);


            dgvcardate.ClearSelection();
        }

        private void btOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);

                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveDate.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveDate.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, carReports);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202029DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202029DataSet.CarReport);
            dgvcardate.Columns[0].Visible = false; //idを非表示にする
            #region
            /*
            if (ofdOpenDate.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenDate.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();


                        carReports = (BindingList<CarReport>)formatter.Deserialize(fs);

                        dgvcardate.DataSource = carReports;

                        dgvcardate_Click(sender, e);       
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }

                }
                
            }*/
            #endregion

            

           
        }



        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }
        
       

        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setMakerRadioButtonSet(string maker)
        {
            switch (maker)
            {
                case "トヨタ":
                    rdbtoyota.Checked = true;
                    break;
                case "日産":
                    rdbniisan.Checked = true;
                    break;
                case "ホンダ":
                    rdbhonda.Checked = true;
                    break;
                case "スバル":
                    rdbsubaru.Checked = true;
                    break;
                case "外車":
                    rdbgaisya.Checked = true;
                    break;
                case "その他":
                    rdboter.Checked = true;
                    break;
                default:
                    break;
            }
        }


        private void dgvcardate_Click_1(object sender, EventArgs e)
        {
            var maker = dgvcardate.CurrentRow.Cells[3].Value;
            //string maker = dgvcardate.CurrentRow.Cells[3].Value.ToString();

            dtpCreate.Value = (System.DateTime)dgvcardate.CurrentRow.Cells[1].Value;
            cbAuthor.Text = dgvcardate.CurrentRow.Cells[2].Value.ToString();
            cbName.Text = dgvcardate.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvcardate.CurrentRow.Cells[5].Value.ToString();
           

            pbImage.Image = ByteArrayToImage((byte[])dgvcardate.CurrentRow.Cells[6].Value);

            


            //setMakerRadioButtonSet(maker) ;
            setMakerRadioButtonSet((string)maker);




        }
        


        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202029DataSet);

        }

        // バイト配列をImageオブジェクトに変換 
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }




    }
}

