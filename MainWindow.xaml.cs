using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        
    }

    

    public int calculate(int v, int vt, bool add, bool subtract)
    {

        if (add == true && subtract == false)
        {
            return v + vt;
        }
        else if (add != true && subtract == true)
        {
            return v - vt;
        }


        if (add == false && subtract == false)
        {
            return 0;
        }
        else if (add == false && subtract == false && v == 0 && vt == 0)
        {
            return 0;
        }
        return 0;


    }

    public int on_add(object sender, RoutedEventArgs e, int i, int itwo)
    {
        return calculate(i, itwo, true, false);
    }

    public int on_subtract(object sender, RoutedEventArgs e, int i, int itwo)
    {
        return calculate(i, itwo, false, true);
    }



    private void calcbtn(object sender, RoutedEventArgs e)
    {
        bool addchecked = false;
        bool subtractchecked = false;
        int numberone = Convert.ToInt32(numberboxone.Text);
        int numbertwo = Convert.ToInt32(numberboxtwo.Text);

        

        if (addcheckbox.IsChecked == true)
            {
                addchecked = true;
                int val = on_add(null, null, numberone, numbertwo);

                answer.Text = Convert.ToString(val);
            }
            else if (addcheckbox.IsChecked != true && subtractcheckbox.IsChecked == true)
            {
                subtractchecked = true;
                addchecked = false;

                int val = on_subtract(null, null, numberone, numbertwo);

                answer.Text = Convert.ToString(val);

            }
            else
            {
                subtractchecked = false;
                addchecked = false;
            }

        if (addcheckbox.IsChecked == true && subtractcheckbox.IsChecked == true)
        {
            subtractchecked = false;
            addchecked = false;

            answer.Text = "0";
        }
    }

    
}