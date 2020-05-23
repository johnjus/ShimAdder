//ShimAdder
//Justin Johnson
//CSC 370
//purpose of this application is to allow an industrial worker to input the shim weights that come off the press and provide information
//about total of the shim weights. It also also allows the user to print a pdf version of the excel document, save data to excel document
//and open excel document that contains saved data


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ShimAdder
{
    public partial class Form1 : Form
    {
        ShimAdder shimAdder = new ShimAdder();
        public Form1()
        {
            InitializeComponent();
        }
        //givees the user the ability to use the shim weight they enter and build a shimadder object off of that value to represent the UI data
        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(enterTB.Text) != 0 | enterTB.Text.Length == 0)
                {

                    if (!checkLimit())
                    {
                        if (shimAdder.open)
                        {
                            shimAdder.setPrevious();
                            shimAdder.setWeight(Convert.ToDouble(enterTB.Text));
                            shimAdder.setTotalWeight();
                            shimAdder.setInput();
                            shimAdder.setMinMax();
                            shimAdder.setPreviousWeight();
                            shimAdder.addWeight();
                            shimAdder.setWeightLimit(Convert.ToInt32(WLTB.Text));
                            fillUI();
                            shimAdder.open = false;
                            shimAdder.clearedEntered = false;
                            shimAdder.undoEntered = false;
                            enterTB.Focus();
                        }
                        else
                        {

                            shimAdder.setPrevious(); 
                            shimAdder.setWeight(Convert.ToDouble(enterTB.Text));
                            shimAdder.setTotalWeight();
                            shimAdder.setInput();
                            shimAdder.setMax(Convert.ToDouble(enterTB.Text));
                            shimAdder.setMin(Convert.ToDouble(enterTB.Text));
                            shimAdder.setWeightLimit(Convert.ToInt32(WLTB.Text));
                            shimAdder.setPreviousWeight();
                            shimAdder.addWeight();
                            shimAdder.clearedEntered = false;
                            shimAdder.undoEntered = false;
                            fillUI();
                            enterTB.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The weight you entered puts you over the limit. " +
                        "Please enter a smaller value or clear the ShimAdder", "Alert");

                    }                 
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value greater than 0 only");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on input. Please make sure you are only entering numerical values into the enter box", "Error on Input");
                enterTB.Clear();
            }
        }

        public void fillUI()
        {
            try
            {
                totalWeightTB.Text = Convert.ToString(shimAdder.getTotalWeight());
                totalInputsTB.Text = Convert.ToString(shimAdder.getInput());
                avgShimWeightTB.Text = Convert.ToString(round(shimAdder.getTotalWeight() / shimAdder.getInput()));
                try
                {
                    stdDShimWeightTB.Text = round(shimAdder.getStDev());
                }
                catch
                {
                    Console.WriteLine("yup");
                }
                MShimeWeightTB.Text = Convert.ToString(shimAdder.getMax());
                mShimWeightTB.Text = Convert.ToString(shimAdder.getMin());
                WLeftTB.Text = Convert.ToString(shimAdder.getWeightLimit() - shimAdder.getTotalWeight());
                enterTB.Clear();
            }
            catch
            {
                MessageBox.Show("Error on updating user interface", "Error Message about User Interface");
            }
        }
        //Wanted to be able to clear the shim adder UI and shim adder object so the user can start fresh if they want to
        private void clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!shimAdder.clearedEntered)
                {
                    shimAdder.Reset();
                    WLTB.Text = Convert.ToString(shimAdder.getWeightLimit());
                    fillUI();

                }
                else
                {
                    MessageBox.Show("Cannot clear more then once in a row.", "Important Message about Clear");
                }
                enterTB.Focus();
            }
            catch
            {
                MessageBox.Show("Error on execution of clear button", "Error Message about Clear");
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!shimAdder.undoEntered)
                {
                    shimAdder.undoTotalWeight();
                    shimAdder.undoMax();
                    shimAdder.undoMin();
                    shimAdder.undoInput();
                    shimAdder.undoWeight();
                    shimAdder.undoEnteredWeight();
                    shimAdder.getAverage();
                    shimAdder.getStDev();
                    fillUI();
                    shimAdder.undoEntered = true;
                }
                else
                {
                    MessageBox.Show("Cannot undo more then 1 time in a row. ", "Important Message about Undo");
                }
                enterTB.Focus();
            }
            catch
            {
                MessageBox.Show("Error occured during execution of undo click", "Error Message about Undo");
            }
        }
        //used to round the double fields of avg and std Dev so the number fits in the UI txt box
        public String round(double input)
        {
            string newinput = Convert.ToString(input);
            string rounded = "";
            for(int i = 0; i < newinput.Length; i++)
            {
                if(newinput.Length < 4)
                {
                    return newinput;

                }
                else if (newinput.Length >= 4)
                {
                    rounded += newinput[0];
                    rounded += newinput[1];
                    rounded += newinput[2];
                    rounded += newinput[3];
                    break;
                }
            }
            return rounded;
        }

        public Boolean checkLimit()
        {
            Boolean limitReached = false;

            if ( (Convert.ToInt32(enterTB.Text) + Convert.ToInt32(totalWeightTB.Text)) > Convert.ToInt32(WLTB.Text))
            {
                limitReached = true;
            }
            else
            {
                limitReached = false;
            }
            return limitReached;

        }
        //built an excel build method to save the UI data to an excel sheet seperate from the save button pressed function
        public void buildExcel(Excel excel)
        {
            try
            {
                int cellcounter = 1;
                while (true)
                {
                    if (excel.isCellEmpty(cellcounter, 1) && excel.isCellEmpty(cellcounter, 2))
                    {
                        excel.writeToCell(cellcounter, 1, Convert.ToString(DateTime.Today));
                        excel.writeToCell(cellcounter + 1, 1, "Total Weight");
                        excel.writeToCell(cellcounter + 1, 2, Convert.ToString(shimAdder.getTotalWeight()));
                        excel.writeToCell(cellcounter + 2, 1, "Bundle Limit");
                        excel.writeToCell(cellcounter + 2, 2, Convert.ToString(shimAdder.getWeightLimit()));
                        excel.writeToCell(cellcounter + 3, 1, "Total Inputs");
                        excel.writeToCell(cellcounter + 3, 2, Convert.ToString(shimAdder.getInput()));
                        excel.writeToCell(cellcounter + 4, 1, "Average Shim Weight");
                        excel.writeToCell(cellcounter + 4, 2, Convert.ToString(shimAdder.getAverage()));
                        excel.writeToCell(cellcounter + 5, 1, "Std Dev of Shim Weights");
                        excel.writeToCell(cellcounter + 5, 2, Convert.ToString(shimAdder.getStDev()));
                        excel.writeToCell(cellcounter + 6, 1, "Max Shim Weight");
                        excel.writeToCell(cellcounter + 6, 2, Convert.ToString(shimAdder.getMax()));
                        excel.writeToCell(cellcounter + 7, 1, "Min Shim Weight");
                        excel.writeToCell(cellcounter + 7, 2, Convert.ToString(shimAdder.getMin()));
                        cellcounter++;
                        break;
                    }
                    else
                    {
                        cellcounter++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save Shim Adder data to excel file", "Error on Save");
            }
            
        }
        //allows the user to save the ShimAdder UI to an excel sheet
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel shimAdderExcel = new Excel(System.AppDomain.CurrentDomain.BaseDirectory + "ShimAdder.xlsx", 1);
                buildExcel(shimAdderExcel);
                shimAdderExcel.Save();
                shimAdderExcel.Close();
            }
            catch
            {
                MessageBox.Show("Could not save Shim Adder data to excel file", "Error on Save");
            }
        }
        //allows the user the ability to print what the ShimAdder excel sheet contains to a pdf
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                info.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "ShimAdder.xlsx";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.StartInfo = info;
                p.Start();

                p.WaitForInputIdle();
                System.Threading.Thread.Sleep(10000);
                if (false == p.CloseMainWindow())
                    p.Kill();
            }
            catch
            {
                MessageBox.Show("Could not print Shim Adder data to excel file", "Error on Print");
            }
        }

        //wanted to give the user the abilty to open the excel file the save to incase the want to hard code a value in
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Excel shimAdderExcel = new Excel(System.AppDomain.CurrentDomain.BaseDirectory + "ShimAdder.xlsx", 1);
                shimAdderExcel.openfile(System.AppDomain.CurrentDomain.BaseDirectory + "ShimAdder.xlsx");
            }
            catch
            {
                MessageBox.Show("Could not open ShimAdder.xlsx data to excel file", "Error on Open");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.BaseDirectory + "Help.txt");
            }
            catch
            {
                MessageBox.Show("Error on opening help text file", "Error on Help");
            }
        }
    }
    //shimAdder object that contains all the functions/methods to alter the shim add object
    public class ShimAdder
    {
        Double[] enteredWeights = new Double[100];
        double totalWeight;
        double Weight;
        double previousWeight;
        double Max;
        double previousMax;
        double Min;
        double previousMin;
        int input;
        int weighLimit;
        public Boolean open = true;
        public Boolean clearedEntered = false;
        public Boolean undoEntered = false;
        public ShimAdder()
        {
        }
        public void setTotalWeight()
        {
            this.totalWeight += this.Weight;
        }
        public void setMinMax()
        {
            this.Min = this.totalWeight;
            this.Max = this.totalWeight;
        }
        public void setWeight(double weight)
        {
            this.Weight = weight;
        }
        public void setPrevious()
        {
       
            this.previousMax = this.Max;
            this.previousMin = this.Min;
        }
        public void setPreviousWeight()
        {
            this.previousWeight = this.Weight;
        }
        public void setInput()
        {
            input += 1;
        }
        public void setMax(double weight)
        {
            if (weight > this.Max)
            {
                this.Max = weight;
            }
        }
        public void setMin(double weight)
        {
            if (weight<this.Min)
            {
                this.Min = weight;
            }
        }
        public void setWeightLimit(int WL)
        {
            this.weighLimit = WL;
        }
        public int getInput()
        {
            return this.input;
        }
        public double getPreviousWeight()
        {
            return this.previousWeight;
        }
        public double getTotalWeight()
        {
            return this.totalWeight;
        }
        public double getWeight()
        {
            return this.Weight;
        }
        public double getMax()
        {
            return this.Max;
        }
        public double getMin()
        {
            return this.Min;
        }
        public double getStDev()
        { 
            double variance = 0;
            for (int i = 0; i < enteredWeights.Length; i++)
            { 
                if (enteredWeights[i] != 0)
                {
                    variance += ((enteredWeights[i] - (this.totalWeight / this.input)) * (enteredWeights[i] - (this.totalWeight / this.input)));
                }
            }
            return Convert.ToDouble(Math.Sqrt(variance / this.input));
        }
        public double getAverage()
        {
            return this.totalWeight / this.input;
        }
        public int getWeightLimit()
        {
            return this.weighLimit;
        }
        public void addWeight()
        {
            enteredWeights[this.input-1] = this.Weight;
        }
        public void Reset()
        {
            this.totalWeight = 0;
            this.Weight = 0;
            this.previousWeight = 0;
            this.Max = 0;
            this.previousMax = 0;
            this.Min = 0;
            this.previousMin = 0;
            this.input = 0;
            this.weighLimit = 5;
            this.clearedEntered = true;
            this.undoEntered = true;
            Array.Clear(enteredWeights, 0, enteredWeights.Length-1);
            this.open = true;
    }
        public void undoTotalWeight()
        {
            this.totalWeight = this.totalWeight - this.previousWeight;
        }      
        public void undoMax()
        {
            this.Max = this.previousMax;
        }
        public void undoMin()
        {
            this.Min = this.previousMin;
        }
        public void undoWeight()
        {
            this.Weight = this.previousWeight;
        }
        public void undoInput()
        {
            this.input = this.input - 1;
        }
        public void undoEnteredWeight()
        {
            enteredWeights[input] = 0;
        }
    }
    //gives the user the ability to save to an excel file
    //it conatains the build in excel parts and getters and setters 
    public class Excel
    {
        //class which allows for the creation and management of excel files
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public Excel()
        {

        }

        public string readCell(int x, int y)
        {
            return Convert.ToString(ws.Cells[x, y].Value2);
        }
        public Boolean isCellEmpty(int i, int j)
        {
            if (ws.Cells[i, j].Value == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void writeToCell(int x, int y, string newVal)
        {
            ws.Cells[x, y].Value2 = newVal;
        }

        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }

        public void CreateNewSheet()
        {
            Worksheet tempSheet = wb.Worksheets.Add(After: ws);
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void openfile(string path)
        {
            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;

            Microsoft.Office.Interop.Excel.Workbook sheet = books.Open(path);

        }

        public void Close()
        {
            wb.Close();
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
        }
    }
}
