using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tile_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int index = cmbTileUnits.FindString("Meters");
            cmbTileUnits.SelectedIndex = index;
            cmbAreaUnits.SelectedIndex = index;
        }



        public bool IsValidValue(string textValue)
        {
            Regex pattern = new Regex(@"(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.[0-9][0-9]?$)");
            if (pattern.IsMatch(textValue))
                return true;
            else
                return false;

        }
        #region Text fields Validation

        private void txtTileWidth_Validating(object sender, CancelEventArgs e)
        {
            if (txtTileWidth.Text == string.Empty)
            {
                errorProviderEmpty.SetError(txtTileWidth, "Width field is empty !");
                errorProviderError.SetError(txtTileWidth, "");
                lblTileWidthError.Text = errorProviderEmpty.GetError(txtTileWidth);
                lblTileWidthError.Visible = true;
            }

            else if (!IsValidValue(txtTileWidth.Text))
            {
                errorProviderError.SetError(txtTileWidth, "Width value is not correct !");
                errorProviderEmpty.SetError(txtTileWidth, "");
                lblTileWidthError.Text = errorProviderError.GetError(txtTileWidth);
                lblTileWidthError.Visible = true;
            }
            else
            {
                errorProviderError.SetError(txtTileWidth, "");
                errorProviderEmpty.SetError(txtTileWidth, "");
                lblTileWidthError.Visible = false;
            }
        }

        private void txtTileLength_Validating(object sender, CancelEventArgs e)
        {
            if (txtTileLength.Text == string.Empty)
            {
                errorProviderEmpty.SetError(txtTileLength, "Length field is empty !");
                errorProviderError.SetError(txtTileLength, "");
                lblTileLengthError.Text = errorProviderEmpty.GetError(txtTileLength);
                lblTileLengthError.Visible = true;
            }

            else if (!IsValidValue(txtTileLength.Text))
            {
                errorProviderError.SetError(txtTileLength, "Length value is not correct !");
                errorProviderEmpty.SetError(txtTileLength, "");
                lblTileLengthError.Text = errorProviderError.GetError(txtTileLength);
                lblTileLengthError.Visible = true;
            }
            else
            {
                errorProviderError.SetError(txtTileLength, "");
                errorProviderEmpty.SetError(txtTileLength, "");
                lblTileLengthError.Visible = false;
            }
        }

        private void txtAreaWidth_Validating(object sender, CancelEventArgs e)
        {
            if (txtAreaWidth.Text == string.Empty)
            {
                errorProviderEmpty.SetError(txtAreaWidth, "Width field is empty !");
                errorProviderError.SetError(txtAreaWidth, "");
                lblAreaWidthError.Text = errorProviderEmpty.GetError(txtAreaWidth);
                lblAreaWidthError.Visible = true;
            }

            else if (!IsValidValue(txtAreaWidth.Text))
            {
                errorProviderError.SetError(txtAreaWidth, "Width value is not correct !");
                errorProviderEmpty.SetError(txtAreaWidth, "");
                lblAreaWidthError.Text = errorProviderError.GetError(txtAreaWidth);
                lblAreaWidthError.Visible = true;
            }
            else
            {
                errorProviderError.SetError(txtAreaWidth, "");
                errorProviderEmpty.SetError(txtAreaWidth, "");
                lblAreaWidthError.Visible = false;
            }
        }

        private void txtAreaLength_Validating(object sender, CancelEventArgs e)
        {
            if (txtAreaLength.Text == string.Empty)
            {
                errorProviderEmpty.SetError(txtAreaLength, "Length field is empty !");
                errorProviderError.SetError(txtAreaLength, "");
                lblAreaLengthError.Text = errorProviderEmpty.GetError(txtAreaLength);
                lblAreaLengthError.Visible = true;
            }

            else if (!IsValidValue(txtAreaLength.Text))
            {
                errorProviderError.SetError(txtAreaLength, "Length value is not correct !");
                errorProviderEmpty.SetError(txtAreaLength, "");
                lblAreaLengthError.Text = errorProviderError.GetError(txtAreaLength);
                lblAreaLengthError.Visible = true;
            }
            else
            {
                errorProviderError.SetError(txtAreaLength, "");
                errorProviderEmpty.SetError(txtAreaLength, "");
                lblAreaLengthError.Visible = false;
            }
        }

        #endregion


        #region Button click

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if ((errorProviderEmpty.GetError(txtAreaWidth) != string.Empty) || (errorProviderError.GetError(txtAreaWidth) != string.Empty)
                || (errorProviderEmpty.GetError(txtAreaLength) != string.Empty) || (errorProviderError.GetError(txtAreaLength) != string.Empty))
            {
                lblError.Text = "Please correct error fields !";
                lblError.Visible = true;
            }
            else
            {
                double currentArea = double.Parse(txtAreaWidth.Text) * double.Parse(txtAreaLength.Text);
                double currentTotal = double.Parse(txtTotalArea.Text);
                double totalArea = Math.Round((currentTotal + currentArea) * 100) / 100;
                txtTotalArea.Text = totalArea.ToString();
                txtAreaWidth.Text = "0";
                txtAreaLength.Text = "0";
                lblError.Visible = false;
            }
        }

        private void btnResetArea_Click(object sender, EventArgs e)
        {
            txtAreaWidth.Text = "0";
            txtAreaLength.Text = "0";
            txtTotalArea.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool errorFree = true;
            var input = new List<Control> { txtTileWidth, txtTileLength, txtAreaWidth, txtAreaLength };
            
            for (int i = 0; i < input.Count; i++) 
            { 
			    if(errorProviderEmpty.GetError(input[i]) != string.Empty || errorProviderError.GetError(input[i]) != string.Empty)	
                {
                    errorFree = false;
                }
		    }

		    if (!errorFree)
            {
			    lblError.Text = "Please correct error fields !";
			    lblError.Visible = true;
		    }
		    else	
            {
			    if((txtTileWidth.Text == "0" || txtTileLength.Text == "0")
                    || (txtAreaWidth.Text == "0" || txtAreaLength.Text == "0") && txtTotalArea.Text == "0")
                {
				    lblError.Text = "Tile size or Area values cannot be zero !";
				    lblError.Visible = true;
			    }
			    else	
                {
				    double area = double.Parse(txtAreaWidth.Text) * double.Parse(txtAreaLength.Text) + double.Parse(txtTotalArea.Text);
				    txtTotalArea.Text = (Math.Round(area * 100)/100).ToString();
				    double tileSize = double.Parse(txtTileWidth.Text) * double.Parse(txtTileLength.Text);
				    area = AreaConverter(area, cmbAreaUnits.SelectedItem.ToString().Trim());
				    tileSize = AreaConverter(tileSize, cmbTileUnits.SelectedItem.ToString().Trim());
				    double tileTotal = Math.Ceiling(area/tileSize);
				    txtTotalTiles.Text = tileTotal.ToString();				
				    txtAreaWidth.Text = "0";
				    txtAreaLength.Text = "0";
                    lblError.Visible = false;
			    }
		    }
        }

        #endregion

        private double AreaConverter(double value, string units)
        {
            double sqMeterValue = 0;
            switch (units)	{
			case "Meters":
				sqMeterValue = value;
				break;
			case "Millimeters":
				sqMeterValue = value/1000000;
				break;
			case "Centimeters":
				sqMeterValue = value/10000;
				break;
			case "Yards":
				sqMeterValue = value/1.1960;
				break;
			case "Feet":
				sqMeterValue = value/10.764;
				break;
			case "Inches":
				sqMeterValue = value/1550;
				break;
			default:
				sqMeterValue = value;
                break;
		}
            return sqMeterValue;
        }

        private void cmbAreaUnits_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbAreaUnits.SelectedItem.ToString().Trim())
            {
                case "Meters":
                    lblUnits.Text = "m²";
                    break;
                case "Millimeters":
                    lblUnits.Text = "mm²";
                    break;
                case "Centimeters":
                    lblUnits.Text = "cm²";
                    break;
                case "Yards":
                    lblUnits.Text = "yd²";
                    break;
                case "Feet":
                    lblUnits.Text = "ft²";
                    break;
                case "Inches":
                    lblUnits.Text = "in²";
                    break;
            }
        }
    }
}
