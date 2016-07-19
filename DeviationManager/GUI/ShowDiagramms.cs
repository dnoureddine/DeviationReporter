using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviationManager.GUI
{
    public partial class ShowDiagramms : Form
    {

        public ShowDiagramms(DataGridView dataGridView)
        {
            InitializeComponent();

            this.showDiagramms(dataGridView);
            
        }

        //add diagramms
        private void showDiagramms(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                //verify the extention file 
                String filePath = row.Cells[1].Value.ToString();
                String fileExtention = Path.GetExtension(row.Cells[0].Value.ToString());
                if (fileExtention.Equals(".png", StringComparison.InvariantCultureIgnoreCase) || fileExtention.Equals(".jpg", StringComparison.InvariantCultureIgnoreCase))
                {

                    if (File.Exists(filePath))
                    {
                        Image img = Image.FromFile(filePath);
                        PictureBox pic = new PictureBox();
                        pic.Image = img;
                        pic.Size = img.Size;
                        pic.Anchor = AnchorStyles.Left;
                        pic.Anchor = AnchorStyles.Right;

                        Label imageLegend = new Label();
                        if (row.Cells[3].Value != null)
                        {
                            imageLegend.Text = row.Cells[3].Value.ToString();
                        }
                        imageLegend.Margin = new Padding(0, 0, 70, 70);

                        this.imagePanel.Controls.Add(pic);
                        this.imagePanel.Controls.Add(imageLegend);
                    }
                 
                }


            }
        }


        /****____classs ****/
        
    }
}
