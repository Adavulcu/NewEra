using NewEra.DepoSimu.Models;
using NewEraDepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEra.DepoSimu
{
    public partial class FormRafDetay : Form
    {
       
        RafModel _raf;
        int _minWidth =40;
        int _maxWidth = 50;
        TableLayoutPanel _tblLyt;
        TableLayoutPanel _subTblLyt;
        private int _width;
        private int _height;
        Label _lbl;
        Color _fullColor;
        Color _emptyColor;
        Padding _pd;

        public FormRafDetay()
        {
            InitializeComponent();
        }



        public void Init(string rafAdi, int y, int x)
        {
            try
            {
                // this.Text = DM.ProjectName + raf; 
                _pd = new Padding(2,2, 2, 2);
                _raf = new RafModel(rafAdi, y, x);
                this.WindowState = FormWindowState.Maximized;
                _fullColor = Color.LightGreen;
                _emptyColor = Color.DimGray;
                _tblLyt = tableLayoutPanel1;
                _width = 100 / _raf.RafX;
                _height = 100 / _raf.RafY;
                CreateKoy();
                CreateOran();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n" + ex.Message);
            }
        }

        private void CreateOran()
        {
            try
            {
                TableLayoutPanel tbl = new TableLayoutPanel()
                {
                    Width = _width,
                    Height = _height * 2,
                   MinimumSize=new Size(_minWidth*_raf.RafX,_height * 2),
                    Dock = DockStyle.Bottom
                };
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, _height * 2));
                for (int i = 0; i < _raf.RafX; i++)
                {
                    tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, _width));
                    tbl.Controls.Add(CreateOranLabel(GetLabelOran(_subTblLyt, i)), i, 0);
                }
              
                grBoxOran.Controls.Add(tbl);
                
               // _tblLyt.Controls.Add(xtraScrollableControl1, 0, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateOran\n" + ex.Message);
            }
        }

        private Label CreateOranLabel(int oran)
        {
            Label lbl = new Label()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "%" + oran.ToString()
            };
            lbl.Margin = _pd;
            return lbl;
        }

        private int GetLabelOran(TableLayoutPanel tbl, int colIndex)
        {
            int total = 0;
            try
            {
                Label lbl = new Label();

                for (int i = 0; i < _raf.RafY; i++)
                {
                    lbl = (Label)tbl.GetControlFromPosition(colIndex, i);
                    KoyModel k = (KoyModel)lbl.Tag;
                    if (k.State)
                    {
                        total++;
                    }
                }

                return (total * 100) / _raf.RafY;
            }
            catch (Exception ex)
            {

                MessageBox.Show("GetLabelOran\n" + ex.Message);
                return 0;
            }

        }



        private void CreateKoy()
        {
            try
            {

                _subTblLyt = new TableLayoutPanel
                {
                    Width = _width * _raf.RafX,
                    Height = _width * _raf.RafY,
                    MinimumSize = new Size(_minWidth * _raf.RafX, _raf.RafY* _minWidth),
                  //  Dock = DockStyle.Fill

                };
                for (int i = 0; i < _raf.RafX; i++)
                {
                    _subTblLyt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, _width));
                    for (int j = 0; j < _raf.RafY; j++)
                    {
                        _subTblLyt.RowStyles.Add(new RowStyle(SizeType.Percent, _height));

                        _subTblLyt.Controls.Add(CreateLabel(_raf.Koy[i, j]), i, j);
                    }
                }
                grBoxKoy.Controls.Add(_subTblLyt);
              //  _tblLyt.Controls.Add(xtraScrollableControl2, 0, 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateKoy\n" + ex.Message);
            }
        }

        private Label CreateLabel(KoyModel koy)
        {
            Color clr = new Color();
            if (koy.State)
                clr = _fullColor;
            else
                clr = _emptyColor;
            _lbl = new Label()
            {
                Text = koy.KoyX,
                Name = koy.KoyX + "-" + koy.KoyY,
                Dock = DockStyle.Fill,
                Tag = koy,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = clr
            };
            _lbl.Click += LblClick;
            _lbl.Margin = _pd;
            return _lbl;
        }

        private void LblClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            MessageBox.Show(lbl.Name);
        }

        private void FormRafDetay_Shown(object sender, EventArgs e)
        {
            Init("A RAFI", 7, 50);
        }
    }
}
