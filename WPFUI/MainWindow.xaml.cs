using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isWebToggled;
        private bool isDisplayingWebPage = false;
        
        public MainWindow()
        {
            InitializeComponent();
            isWebToggled = true;
        }

        private void hoverStyling(TextBlock name, bool isBeingHoveredOver)
        {
            if(isBeingHoveredOver == true)
            {
                Cursor = Cursors.Hand;
                name.FontSize = 18;
                name.FontWeight = FontWeights.SemiBold;
                name.Foreground = Brushes.CornflowerBlue;
            }
            else
            {
                Cursor = Cursors.Arrow;
                name.FontSize = 14;
                name.FontWeight = FontWeights.Normal;
                name.Foreground = Brushes.Black;
            }
        }

        private void pnlDocs_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isWebToggled == true)
            {
                pnlDocs.Background = Brushes.AliceBlue;
            }
            Cursor = Cursors.Hand;
        }

        private void pnlDocs_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isWebToggled == true)
            {
                pnlDocs.Background = Brushes.White;
            }
            Cursor = Cursors.Arrow;
        }

        private void pnlDocs_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isDisplayingWebPage)
            {
                cwbOfficeThreeSixFiveBrowser.Visibility = Visibility.Collapsed;
                cwbSelworthySchoolWebsiteBrowser.Visibility = Visibility.Collapsed;
                cwbStaffAbsenceManagementBrowser.Visibility = Visibility.Collapsed;
                pnlClose.Visibility = Visibility.Collapsed;
                isDisplayingWebPage = false;
            }
            isWebToggled = false;
            pnlDocs.Background = Brushes.CornflowerBlue;
            pnlWeb.Background = Brushes.White;
            pnlWebLinks.Visibility = Visibility.Collapsed;
            pnlDocLinks.Visibility = Visibility.Visible;
        }

        private void pnlWeb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isDisplayingWebPage)
            {
                cwbOfficeThreeSixFiveBrowser.Visibility = Visibility.Collapsed;
                cwbSelworthySchoolWebsiteBrowser.Visibility = Visibility.Collapsed;
                cwbStaffAbsenceManagementBrowser.Visibility = Visibility.Collapsed;
                pnlClose.Visibility = Visibility.Collapsed;
                isDisplayingWebPage = false;
            }
            isWebToggled = true;
           pnlWeb.Background = Brushes.CornflowerBlue;
           pnlDocs.Background = Brushes.White;
           pnlDocLinks.Visibility = Visibility.Collapsed;
           pnlWebLinks.Visibility = Visibility.Visible;
        }

        private void pnlWeb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isWebToggled == false)
            {
                pnlWeb.Background = Brushes.White;
            }
            Cursor = Cursors.Arrow;
        }

        private void pnlWeb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isWebToggled == false)
            {
                pnlWeb.Background = Brushes.AliceBlue;
            }
            Cursor = Cursors.Hand;
        }

        private void txtStaffAbsenceManagementLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtStaffAbsenceManagementLink, true);
        }

        private void txtStaffAbsenceManagementLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtStaffAbsenceManagementLink, false);
        }

        private void txtStaffAbsenceManagementLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDisplayingWebPage = true;
            pnlWebLinks.Visibility = Visibility.Collapsed;
            cwbStaffAbsenceManagementBrowser.Visibility = Visibility.Visible;
            pnlClose.Visibility = Visibility.Visible;
        }

        private void txtSelworthySchoolWebsiteLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtSelworthySchoolWebsiteLink, true);
        }

        private void txtSelworthySchoolWebsiteLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtSelworthySchoolWebsiteLink, false);
        }

        private void txtSelworthySchoolWebsiteLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDisplayingWebPage = true;
            pnlWebLinks.Visibility = Visibility.Collapsed;
            cwbSelworthySchoolWebsiteBrowser.Visibility = Visibility.Visible;
            pnlClose.Visibility = Visibility.Visible;
        }

        private void txtOfficeThreeSixFiveLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtOfficeThreeSixFiveLink, true);
        }

        private void txtOfficeThreeSixFiveLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtOfficeThreeSixFiveLink, false);
        }

        private void txtOfficeThreeSixFiveLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDisplayingWebPage = true;
            pnlWebLinks.Visibility = Visibility.Collapsed;
            cwbOfficeThreeSixFiveBrowser.Visibility = Visibility.Visible;
            pnlClose.Visibility = Visibility.Visible;
        }

        private void openDocument(string filePath)
        {
            Process openDoc = new Process();
            openDoc.StartInfo.FileName = filePath;
            openDoc.StartInfo.UseShellExecute = true;
            openDoc.Start();
        }

        private void txtCCOFormLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtCCOFormLink, true);
        }

        private void txtCCOFormLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtCCOFormLink, false);
        }

        private void txtCCOFormLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            openDocument("P:/Filling Cabinet Forms/CorporateBankingCardControlForm.doc");
        }

        private void txtERFormLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtERFormLink, true);
        }

        private void txtERFormLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtERFormLink, false);
        }

        private void txtERFormLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            openDocument("P:/Filling Cabinet Forms/ExpenditureReinbursementForm.docx");
        }

        private void txtRFormLink_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverStyling(txtRFormLink, true);
        }

        private void txtRFormLink_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverStyling(txtRFormLink, false);
        }

        private void txtRFormLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            openDocument("P:/Filling Cabinet Forms/RequisitionForm.doc");
        }

        private void pnlClose_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isDisplayingWebPage == true)
            {
                pnlClose.Background = Brushes.Yellow;
            }
            Cursor = Cursors.Hand;
        }

        private void pnlClose_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isDisplayingWebPage == true)
            {
                pnlClose.Background = Brushes.LightYellow;
            }
            Cursor = Cursors.Arrow;
        }

        private void pnlClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDisplayingWebPage = false;
            pnlClose.Visibility = Visibility.Collapsed;
            cwbOfficeThreeSixFiveBrowser.Visibility = Visibility.Collapsed;
            cwbSelworthySchoolWebsiteBrowser.Visibility = Visibility.Collapsed;
            cwbStaffAbsenceManagementBrowser.Visibility = Visibility.Collapsed;
            pnlWebLinks.Visibility = Visibility.Visible;
            pnlClose.Background = Brushes.LightYellow;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F11)
            {
                WindowStyle = WindowStyle.None;
                WindowState = WindowState.Maximized;
                ResizeMode = ResizeMode.NoResize;
            }
        }
    }
}
