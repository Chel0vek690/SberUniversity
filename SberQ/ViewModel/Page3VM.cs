using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using SberQ.Assets.Text;
using System.Windows.Controls;

namespace SberQ.ViewModel
{
    public partial class Page3VM : ObservableObject
    {
        private readonly Frame frame;
        [ObservableProperty]
        private string text1;
        [ObservableProperty]
        private string text2;
        [ObservableProperty]
        private string text3;
        [ObservableProperty]
        private string text4;
        [ObservableProperty]
        private string text5;
        [ObservableProperty]
        private string text6;
        [ObservableProperty]
        private string text7;
        [ObservableProperty]
        private string text8;
        [ObservableProperty]
        private string? yourGrade;
        [ObservableProperty]
        private string isPolicyVisible;
        [ObservableProperty]
        private string isAgreementVisible;
        [ObservableProperty]
        private string? policyContent;
        [ObservableProperty]
        private string? agreementContent;
        [ObservableProperty]
        private string? canvasText_Email;
        [ObservableProperty]
        private string? emailText;
        [ObservableProperty]
        private bool isCheckBoxChecked;
        [ObservableProperty]
        private string isErrorModalVisible;


        public Page3VM(string answer, Frame frame)
        {
            IsAgreementVisible = "Collapsed";
            IsPolicyVisible = "Collapsed";
            isErrorModalVisible = "Collapsed";
            IsCheckBoxChecked = false;
            this.frame = frame;
            SetPageText(Convert.ToByte(answer));
        }

        private void SetPageText(byte answer)
        {
            var answers = new Answers();

            if (answer <= 2)
            {
                text1 = answers.answer1Text1;
                text2 = answers.answer1Text2;
                text3 = answers.answer1Text3;
                text4 = answers.answer1Text4;
                text5 = answers.answer1Text5;
                text6 = answers.answer1Text6;
                text7 = answers.answer1Text7;
                text8 = answers.answer1Text8;
                YourGrade = "0-2 баллов";
            }
            else if (answer <= 6)
            {
                text1 = answers.answer2Text1;
                text2 = answers.answer2Text2;
                text3 = answers.answer2Text3;
                text4 = answers.answer2Text4;
                text5 = answers.answer2Text5;
                text6 = answers.answer2Text6;
                text7 = answers.answer2Text7;
                text8 = answers.answer2Text8;
                YourGrade = "3-6 баллов";
            }
            else
            {
                text1 = answers.answer3Text1;
                text2 = answers.answer3Text2;
                text3 = answers.answer3Text3;
                text4 = answers.answer3Text4;
                text5 = answers.answer3Text5;
                text6 = answers.answer3Text6;
                text7 = answers.answer3Text7;
                text8 = answers.answer3Text8;
                YourGrade = "7-10 баллов";
            }
        }

        [RelayCommand]
        private void ShowPolicy()
        {
            IsPolicyVisible = "Visible";
            var policy = new PolicyText();
            PolicyContent = policy.policy;

        }

        [RelayCommand]
        private void ClosePolicy()
        {
            IsPolicyVisible = "Collapsed";
        }

        [RelayCommand]
        private void ShowAgreement()
        {
            var agreement = new AgreementText();
            AgreementContent = agreement.agreemnt;
            IsAgreementVisible = "Visible";
        }

        [RelayCommand]
        private void CloseAgreement()
        {
            IsAgreementVisible = "Collapsed";
        }

        [RelayCommand]
        private void SendEmail()
        {
            if (IsCheckBoxChecked)
            {
                string result = $"Ваш результат: {yourGrade}";
                string body = $"{result}\n{text1}\n{text2}\n{text3}\n{text4}\n{text5}\n{text6}\n{text7}";

                try
                {
                    var toEmail = emailText;
                    var writer = App.ServiceProvider1.GetRequiredService<IData>();
                    var sendEmail = App.ServiceProvider1.GetRequiredService<ISendMessage>();
                    ReadJson jsonData = writer.Load();
                    sendEmail.SendEmail(toEmail, body, jsonData);
                    frame.Navigate(new Page4());
                }
                catch
                {
                    IsErrorModalVisible = "Visible";
                }
            }
        }

        [RelayCommand]
        private void NavigateStart()
        {
            if (isErrorModalVisible == "Visible")
            {
                IsErrorModalVisible = "Collapsed";
            }

            frame.Navigate(new Page1());
        }

        [RelayCommand]
        private void CloseError()
        {
            IsErrorModalVisible = "Collapsed";
        }
    }
}