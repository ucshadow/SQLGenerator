using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQLStatementGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private TextBlock customPreview;
        private TextBlock SQLPreview;
        private TextBox tableTextBox;
        private TextBox numberLength;
        private TextBox output;

        private int currentValueIndex = 0;
        private Values generator = new Values();
        private MethodInfo remember;
        private bool foreignKey = false;

        private List<MethodInfo> executionOrder = new List<MethodInfo>();

        public MainWindow()
        {
            InitializeComponent();
            customPreview = (TextBlock)FindName("CustomPreview");
            SQLPreview = (TextBlock)FindName("SQLPreview_");
            tableTextBox = (TextBox)FindName("TableTextBox");
            numberLength = (TextBox)FindName("NumberLength");
            output = (TextBox)FindName("OutputText");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HandleAddButton(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if(tableTextBox.Text == "")
            {
                tableTextBox.Focus();
                tableTextBox.Background = Brushes.Pink;
            }
            else
            {
                MethodInfo methodInfo = generator.GetType().GetMethod(button.Uid);
                HandleSetup(methodInfo);
                tableTextBox.Background = Brushes.White;
            }            
        }

        private void HandleSetup(MethodInfo methodInfo)
        {
            if(methodInfo.ToString() == "System.String GetCustomValue1()")
            {
                TextBox t = (TextBox)FindName("MoreValues1");
                generator.AddToCustom1(t.Text);
            }
            if (methodInfo.ToString() == "System.String GetCustomValue2()")
            {
                TextBox t = (TextBox)FindName("MoreValues2");
                generator.AddToCustom2(t.Text);
            }
            generator.SetNummberLength(int.Parse(numberLength.Text));
            executionOrder.Add(methodInfo);
            String local = (String)methodInfo.Invoke(generator, null);
            

            customPreview.Text += AddIndex() + local;
            SQLPreview.Text += SolveComma() + (int.TryParse(local, out int parsed) ? local  : "'" + local + "'");
        }

        private void ResetButt(object sender, RoutedEventArgs e)
        {
            customPreview.Text = "";
            currentValueIndex = 0;
            SQLPreview.Text = "INSERT INTO ";
            tableTextBox.Text = "";
            output.Text = "";
            executionOrder.Clear();
            if(remember != null)
            {
                foreignKey = true;
            }
        }

        private void GenerateEntries(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)FindName("NumberOfGenerationsTextField");
            TextBox table = (TextBox)this.FindName("TableTextBox");
            int number = int.Parse(t.Text);
            if(number > 0)
            {                
                for(int i = 0; i < number; i++)
                {
                    currentValueIndex = 1;
                    String res = "INSERT INTO " + table.Text + " VALUES ( ";
                    executionOrder.ForEach(_ => {
                        String local = (String)_.Invoke(generator, null);

                        if (remember != null && remember.Equals(_) && foreignKey == false)
                        {
                            generator.AddToRemember1(local);                            
                        }

                        if (remember != null && remember.Equals(_) && foreignKey == true)
                        {
                            local = generator.GetFromRemember1();
                        }

                        res += SolveComma() + (int.TryParse(local, out int parsed) ? local : "'" + local + "'");
                        currentValueIndex++;
                    });
                    output.Text += res + ");\n";
                }                
            }
        }

        private void HandleRemember(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = Brushes.Pink;
            remember = generator.GetType().GetMethod(button.Uid);
        }

        private void ChangeTableName(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)this.FindName("TableTextBox");
            SQLPreview.Text = "INSERT INTO " + t.Text + " VALUES ( ";
        }

        private String AddIndex()
        {
            currentValueIndex += 1;
            return "[" + (currentValueIndex - 1).ToString() + "]";
        }

        private String SolveComma()
        {
            return currentValueIndex == 1 ? "" : ", ";
        }
    }
}
