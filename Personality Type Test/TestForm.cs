using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            label2.Text = "Вопрос " + count + " из 94";
            label1.Text = quest[count];
            radioButton1.Text = answer_a[count];
            radioButton2.Text = answer_b[count];
        }

        int count = 0;//Счетчик вопросов
        //Массив с вопросами
        string[] quest = new string[] { "Вы", "1. Обычно Вы:", "2. Если бы Вы были преподавателем, какой курс Вы бы предпочли:", "3. Вы чаще позволяете:", "4. Когда Вы отправляетесь куда-то на весь день, Вы:", "5. Находясь в компании, Вы обычно:", "6. Вам легче поладить с людьми:", "7. Более высокой похвалой Вы считаете слова:", "8. Вы предпочитаете:", "9. В большой компании чаще:", "10. Вас скорее можно назвать:", "11. Обычно Вы:", "12. Вы чаще добиваетесь успеха:", "13. Вы предпочитаете:", "14. Вам больше нравятся люди, которые:", "15. На Ваш взгляд самый большой недостаток – быть:", "16. Следование какому-либо расписанию:", "17. Среди своих друзей Вы:", "18. Вы бы предпочли иметь среди своих друзей человека, который:", "19. Вы предпочли бы работать под началом человека, который:", "20. Мысль о том, чтобы составить список дел на выходные:", "21. Вы обычно:", "22. Когда Вы читаете для своего удовольствия, Вам нравится:", "23. Вы считаете, что более серьезный недостаток:", "24. В своей повседневной работе:", "25. Люди могут определить область Ваших интересов:", "26. Выполняя ту же работу, что и многие другие люди, Вы предпочитаете:", "27. Вас больше волнуют:", "28. Когда Вам нужно выполнить определенную работу, Вы обычно:", "29. Обычно Вы:", "30. Вы предпочитаете:", "31. Какое слово из пары (А или Б) Вам больше нравится:", "32. Когда Вам необходимо что-то сделать в определенное время, Вы считаете, что:", "33. Можно сказать, что Вы:", "34. Более высокой похвалой человеку будет признание:", "35. Какое слово из пары (А или Б) Вам больше нравится:", "36. Обычно:", "37. На вечеринках Вам:", "38. Вы считаете, что более важно:", "39. Какое слово из пары (А или Б) Вам больше нравится:", "40. Считаете ли Вы, что наличие стабильного повседневного распорядка:", "41. Когда что-то входит в моду, Вы обычно:", "42. Вы скорее:", "43. Какое слово из пары (А или Б) Вам больше нравится:", "44. Когда Вы думаете о том, что надо сделать какое-то не очень важное дело или купить какую-то мелкую вещь, Вы:", "45. Узнать, что Вы за человек:", "46. Какое слово из пары (А или Б) Вам больше нравится:", "47. Какое слово из пары (А или Б) Вам больше нравится:", "48. Вам труднее приспособиться:", "49. Оказавшись в затруднительной ситуации, Вы обычно:", "50. Какое слово из пары (А или Б) Вам больше нравится:", "51. Какое слово из пары (А или Б) Вам больше нравится:", "52. Когда Вы начинаете какое-то большое дело, которое займет у Вас неделю, Вы:", "53. Вы считаете, что Вашим близким известны Ваши мысли:", "54. Какое слово из пары (А или Б) Вам больше нравится:", "55. Какое слово из пары (А или Б) Вам больше нравится:", "56. Выполняя какую-либо работу, Вы обычно:", "57. Будучи на вечеринке, Вы предпочитаете:", "58. Какое слово из пары (А или Б) Вам больше нравится:", "59. Какое слово из пары (А или Б) Вам больше нравится:", "60. Если в выходной утром Вас спросят, что Вы собираетесь сделать в течение дня, Вы:", "61. Какое слово из пары (А или Б) Вам больше нравится:", "62. Какое слово из пары (А или Б) Вам больше нравится:", "63. Какое слово из пары (А или Б) Вам больше нравится:", "64. Однообразие повседневных дел кажется Вам:", "65. Какое слово из пары (А или Б) Вам больше нравится:", "66. Какое слово из пары (А или Б) Вам больше нравится:", "67. Какое слово из пары (А или Б) Вам больше нравится:", "68. Какое слово из пары (А или Б) Вам больше нравится:", "69. Какое слово из пары (А или Б) Вам больше нравится:", "70. Какое слово из пары (А или Б) Вам больше нравится:", "71. Какое слово из пары (А или Б) Вам больше нравится:", "72. Какое слово из пары (А или Б) Вам больше нравится:", "73. Какое слово из пары (А или Б) Вам больше нравится:", "74. Какое слово из пары (А или Б) Вам больше нравится:", "75. Какое слово из пары (А или Б) Вам больше нравится:", "76. Какое слово из пары (А или Б) Вам больше нравится:", "77. Какое слово из пары (А или Б) Вам больше нравится:", "78. Какое слово из пары (А или Б) Вам больше нравится:", "79. Какое слово из пары (А или Б) Вам больше нравится:", "80. Какое слово из пары (А или Б) Вам больше нравится:", "81. Какое слово из пары (А или Б) Вам больше нравится:", "82. Какое слово из пары (А или Б) Вам больше нравится:", "83. Какое слово из пары (А или Б) Вам больше нравится:", "84. Какое слово из пары (А или Б) Вам больше нравится:", "85. Какое слово из пары (А или Б) Вам больше нравится:", "86. Какое слово из пары (А или Б) Вам больше нравится:", "87. Какое слово из пары (А или Б) Вам больше нравится:", "88. Какое слово из пары (А или Б) Вам больше нравится:", "89. Какое слово из пары (А или Б) Вам больше нравится:", "90. Какое слово из пары (А или Б) Вам больше нравится:", "91. Какое слово из пары (А или Б) Вам больше нравится:", "92. Какое слово из пары (А или Б) Вам больше нравится:", "93. Какое слово из пары (А или Б) Вам больше нравится:", "94. Какое слово из пары (А или Б) Вам больше нравится:" };
        //Массив ответов а
        string[] answer_a = new string[] { "Мужчина", "а) общительны;", "а) построенный на изложении фактов;", "а) своему сердцу управлять разумом;", "а) планируете, что и когда будете делать;", "а) присоединяетесь к общему разговору;", "а) имеющими богатое воображение;", "а) душевный человек;", "а) заранее договариваться о встречах, вечеринках и т.п.;", "а) Вы представляете людей друг другу;", "а) человеком практичным;", "а) цените чувства больше, чем логику;", "а) действуя в непредсказуемой ситуации, когда нужно быстро принимать решения;", "а) иметь несколько близких, верных друзей;", "а) следуют общепринятым нормам и не привлекают к себе внимания;", "а) бесчувственным;", "а) привлекает Вас;", "а) позже других узнаете о событиях в их жизни;", "а) всегда полон новых идей;", "а) всегда добр;", "а) Вас привлекает;", "а) можете легко разговаривать практически с любым человеком в течение любого времени;", "а) необычная, оригинальная манера изложения;", "а) быть слишком сердечным;", "а) Вам больше нравятся критические ситуации, когда Вам приходится работать в условиях дефицита времени;", "а) при первом знакомстве с Вами;", "а) делать это традиционным способом;", "а) чувства людей;", "а) тщательно организовываете все перед началом работы;", "а) свободно выражаете свои чувства;", "а) быть оригинальным;", "а) кроткий;", "а) лучше планировать все заранее;", "а) более восторженны по сравнению с другими людьми;", "а) его способности к предвидению;", "а) мысли;", "а) Вы предпочитаете все делать в последнюю минуту;", "а) иногда становится скучно;", "а) видеть различные возможности в какой-либо ситуации;", "а) убедительный;", "а) очень удобно для выполнения многих дел;", "а) одним из первых испробуете это;", "а) придерживаетесь общепринятых методов в работе;", "а) анализировать;", "а) часто забываете об этом и вспоминаете слишком поздно;", "а) довольно легко;", "а) факты;", "а) справедливость;", "а) к однообразию;", "а) переводите разговор на другое;", "а) утверждение;", "а) сочувствие;", "а) составляете сначала список того, что нужно сделать и в каком порядке;", "а) достаточно хорошо;", "а) теория;", "а) выгода;", "а) планируете работу таким образом, чтобы закончить с запасом времени;", "а) активно участвовать в развитии событий;", "а) буквальный;", "а) решительный;", "а) сможете довольно точно ответить;", "а) энергичный;", "а) образный;", "а) неуступчивый;", "а) спокойным;", "а) сдержанный;", "а) производить;", "а) миротворец;", "а) запланированный;", "а) спокойный;", "а) благоразумный;", "а) мягкий;", "а) методичный;", "а) говорить;", "а) производство;", "а) прощать;", "а) систематический;", "а) общительный;", "а) конкретный;", "а) кто;", "а) импульс;", "а) вечеринка;", "а) сооружать;", "а) некритичный;", "а) пунктуальный;", "а) основание;", "а) осторожный;", "а) переменчивый;", "а) теория;", "а) соглашаться;", "а) дисциплинированный;", "а) знак;", "а) стремительный;", "а) принимать;", "а) известный;" };
        //Массив ответов б
        string[] answer_b = new string[] { "Женщина", "б) довольно сдержанны и спокойны.", "б) включающий в себя изложение теорий.", "б) своему разуму управлять сердцем.", "б) уходите без определенного плана.", "б) беседуете время от времени с кем-то одним.", "б) реалистичными.", "б) последовательно рассуждающий человек.", "б) иметь возможность в последний момент решать, как развлечься.", "б) Вас знакомят с другими.", "б) выдумщиком.", "б) цените логику больше, чем чувства.", "б) следуя тщательно разработанному плану.", "б) иметь дружеские связи с самыми разными людьми.", "б) настолько оригинальны, что им все равно, обращают на них внимание или нет.", "б) неблагоразумным.", "б) сковывает Вас.", "б) обычно знаете массу новостей о них.", "б) трезво и реалистично смотрит на мир.", "б) всегда справедлив.", "б) оставляет Вас равнодушным;", "б) можете найти тему для разговора только с немногими людьми и только в определенных ситуациях.", "б) когда писатели четко выражают свои мысли.", "б) быть недостаточно сердечным.", "б) ненавидите работать в жестких временных рамках;", "б) лишь тогда, когда узнают Вас поближе.", "б) изобретать свой собственный способ.", "б) их права.", "б) предпочитаете выяснять все необходимое в процессе работы.", "б) держите свои чувства при себе.", "б) следовать общепринятым нормам.", "б) настойчивый.", "б) несколько неприятно быть связанным этими планами.", "б) менее восторженны, чем большинство людей.", "б) его здравого смысла.", "б) чувства.", "б) для Вас откладывать все до последней минуты – это слишком большая нервотрепка.", "б) всегда весело.", "б) воспринимать факты такими, какие они есть.", "  б) трогательный.", "б) тягостно, даже когда это необходимо.", "б) мало этим интересуетесь.", "б) ищете, что еще неверно, и беретесь за неразрешенные проблемы.", "б) сопереживать.", "б) записываете это на бумаге, чтобы не забыть;", "б) довольно трудно.", "б) идеи.", "б) сочувствие.", "б) к постоянным переменам.", "б) обращаете все в шутку;", "  б) идея.", "  б) расчетливость.", "б) сразу беретесь за работу.", "б) лишь тогда, когда Вы намеренно сообщаете о них.", "б) факт.", "б) благодеяние.", "б) в последний момент работаете с наивысшей производительностью.", "б) предоставляете другим развлекаться, как им хочется.", "  б) фигуральный.", "б) преданный.", "б) перечислите вдвое больше дел, чем сможете сделать;", " б) спокойный.", "  б) прозаичный.", "б) добросердечный.", "б) утомительным.", " б) разговорчивый.", "  б) создавать.", " б) судья.", "б) внеплановый.", "оживленный.", "б) очаровательный.", " б) твердый.", "б) спонтанный.", " б) писать.", "б) планирование.", "б) дозволять.", " б) случайный.", "б) замкнутый.", "б) абстрактный.", "б) что.", "б) решение.", "б) театр.", "б) изобретать.", "б) критичный.", "б) свободный.", "б) вершина.", "б) доверчивый.", "б) неизменный.", "б) практика.", "б) дискутировать.", "б) беспечный.", "б) символ.", "б) тщательный.", "б) изменять.", "  б) неизвестный." };
        //Массив ответов в
        string[] answer_v = new string[] { "в) угнетает Вас.", "в) обычно планируете свою работу так, чтобы Вам хватило времени.", "в) всегда выполняете это без дополнительных напоминаний.", "в) спустя несколько дней думаете, что Вам следовало сказать.", "в) предпочтете не загадывать заранее." };

        public void NextQuestButton_Click(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                NextQuestButton.Enabled = false;
            }*/
            if (count == 20 || count == 24 || count == 44 || count == 49 || count == 60)
            {
                radioButton3.Visible = true;
                if (count == 20)
                {
                    radioButton3.Text = answer_v[0];
                }
                else if (count == 24)
                {
                    radioButton3.Text = answer_v[1];
                }
                else if (count == 44)
                {
                    radioButton3.Text = answer_v[2];
                }
                else if (count == 49)
                {
                    radioButton3.Text = answer_v[3];
                }
                else if (count == 60)
                {
                    radioButton3.Text = answer_v[4];
                }
            }
            else
            {
                radioButton3.Visible = false;
            }

            //#0 quest
            if (count == 0 && radioButton1.Checked == true)
            {
                Data.pol = true;
            }
            else if (count == 0 && radioButton2.Checked == true)
            {
                Data.pol = false;
            }

            //EI
            //#1,9,21
            if ((count == 1 || count == 9 || count == 21) && radioButton1.Checked == true )
            {
                Data.E += 2;
            }
            else if ((count == 1 || count == 9 || count == 21) && radioButton2.Checked == true)
            {
                Data.I += 2;
            }
            //#5,45,57,61
            if ((count == 5 || count == 45 || count == 57 || count == 61) && radioButton1.Checked == true)
            {
                Data.E++;
            }
            else if ((count == 5 || count == 45 || count == 57 || count == 61) && radioButton2.Checked == true)
            {
                Data.I += 2;
            }
            //#13,17,37,65
            if ((count == 13 || count == 17 || count == 37 || count == 65) && radioButton1.Checked == true)
            {
                Data.I++;
            }
            else if ((count == 13 || count == 17 || count == 37 || count == 65) && radioButton2.Checked == true)
            {
                Data.E += 2;
            }
            //#25,33,53,77
            if ((count == 25 || count == 33 || count == 53 || count == 77) && radioButton1.Checked == true)
            {
                Data.E++;
            }
            else if ((count == 25 || count == 33 || count == 53 || count == 77) && radioButton2.Checked == true)
            {
                Data.I++;
            }
            //#29,81
            if ((count == 29 || count == 81) && radioButton1.Checked == true)
            {
                Data.E++;
            }
            //#41
            if (count == 41 && radioButton2.Checked == true)
            {
                Data.I += 2;
            }
            //#49
            if (count == 49 && radioButton2.Checked == true)
            {
                Data.E++;
            }
            else if (count == 49 && radioButton3.Checked == true)
            {
                Data.I += 2;
            }
            //#69
            if (count == 69 && radioButton1.Checked == true)
            {
                Data.I++;
            }
            else if (count == 69 && radioButton2.Checked == true)
            {
                Data.E++;
            }
            //#73
            if (count == 73 && radioButton2.Checked == true)
            {
                Data.I++;
            }

            //SN
            //#2,10
            if ((count == 2 || count == 10) && radioButton1.Checked == true)
            {
                Data.S += 2;
            }
            else if ((count == 2 || count == 10) && radioButton2.Checked == true)
            {
                Data.N += 2;
            }
            //#6,34,54
            if ((count == 6 || count == 34 || count == 54) && radioButton1.Checked == true)
            {
                Data.N += 2;
            }
            else if ((count == 6 || count == 34 || count == 54) && radioButton2.Checked == true)
            {
                Data.S++;
            }
            //#14,78
            if ((count == 14 || count == 78) && radioButton1.Checked == true)
            {
                Data.S++;
            }
            else if ((count == 14 || count == 78) && radioButton2.Checked == true)
            {
                Data.N += 2;
            }
            //#18
            if (count == 18 && radioButton1.Checked == true)
            {
                Data.N++;
            }
            else if (count == 18 && radioButton2.Checked == true)
            {
                Data.S += 2;
            }
            //#22,38
            if ((count == 22 || count == 38) && radioButton2.Checked == true)
            {
                Data.S++;
            }
            //#26,58,74
            if ((count == 26 || count == 58 || count == 74) && radioButton1.Checked == true)
            {
                Data.S++;
            }
            else if ((count == 26 || count == 58 || count == 74) && radioButton2.Checked == true)
            {
                Data.N++;
            }
            //#30,91,93
            if ((count == 30 || count == 91 || count == 93) && radioButton1.Checked == true)
            {
                Data.S++;
            }
            //#42,66,70
            if ((count == 42 || count == 66 || count == 70) && radioButton1.Checked == true)
            {
                Data.S += 2;
            }
            //#46,50,82
            if ((count == 46 || count == 50 || count ==82) && radioButton1.Checked == true)
            {
                Data.S += 2;
            }
            else if ((count == 46 || count == 50 || count == 82) && radioButton2.Checked == true)
            {
                Data.N = Data.N + 1;
            }
            //#62
            if (count == 62 && radioButton2.Checked == true)
            {
                Data.S = Data.S + 2;
            }
            //#85,88
            if ((count == 85 || count == 88) && radioButton1.Checked == true)
            {
                Data.N = Data.N + 2;
            }

            //JP
            //#4,16,68,72,76
            if ((count == 4 || count == 16 || count == 68 || count == 72 || count == 76) && radioButton1.Checked == true)
            {
                Data.J = Data.J + 2;
            }
            else if ((count == 4 || count == 16 || count == 68 || count == 72 || count == 76) && radioButton2.Checked == true)
            {
                Data.P = Data.P + 2;
            }
            //#8,52,90
            if ((count == 8 || count == 52 || count == 90) && radioButton1.Checked == true)
            {
                Data.J = Data.J + 2;
            }
            else if ((count == 8 || count == 52 || count == 90) && radioButton2.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            //#12,44,48
            if ((count == 12 || count == 44 || count == 48) && radioButton1.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            else if ((count == 12 || count == 44 || count == 48) && radioButton2.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            //#20
            if (count == 20 && radioButton1.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            else if (count == 20 && radioButton2.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            else if (count == 20 && radioButton3.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            //#24
            if (count == 24 && radioButton1.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            else if (count == 24 && radioButton3.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            //#28
            if (count == 28 && radioButton1.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            else if (count == 28 && radioButton2.Checked == true)
            {
                Data.P = Data.P + 2;
            }
            //#32,84
            if ((count == 32 || count == 84) && radioButton1.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            else if ((count == 32 || count == 84) && radioButton2.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            //#36
            if (count == 36 && radioButton1.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            else if (count == 36 && radioButton2.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            //#40
            if (count == 40 && radioButton1.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            else if (count == 40 && radioButton2.Checked == true)
            {
                Data.P = Data.P + 2;
            }
            //#56,92
            if ((count == 56 || count == 92) && radioButton1.Checked == true)
            {
                Data.P = Data.P + 1;
            }
            //#60
            if (count == 60 && (radioButton2.Checked == true || radioButton3.Checked == true))
            {
                Data.P = Data.P + 1;
            }
            //#64
            if (count == 64 && radioButton1.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            //#80
            if (count == 80 && radioButton1.Checked == true)
            {
                Data.P = Data.P + 2;
            }
            else if (count == 80 && radioButton2.Checked == true)
            {
                Data.J = Data.J + 1;
            }
            //#87
            if (count == 87 && radioButton2.Checked == true)
            {
                Data.J = Data.J + 1;
            }

            //TF
            //#3
            if (count == 3 && radioButton1.Checked == true && Data.pol == true)
            {
                Data.F = Data.F + 2;
            }
            else if (count == 3 && radioButton1.Checked == true && Data.pol == false)
            {
                Data.F = Data.F + 1;
            }
            else if (count == 3 && radioButton2.Checked == true && Data.pol == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 3 && radioButton2.Checked == true && Data.pol == false)
            {
                Data.T = Data.T + 2;
            }
            //#7
            if (count == 7 && radioButton1.Checked == true)
            {
                Data.F = Data.F + 1;
            }
            else if (count == 7 && radioButton2.Checked == true)
            {
                Data.T = Data.T + 2;
            }
            //#11
            if (count == 11 && radioButton1.Checked == true)
            {
                Data.F = Data.F + 2;
            }
            else if (count == 7 && radioButton2.Checked == true)
            {
                Data.T = Data.T + 2;
            }
            //#15
            if (count == 15 && radioButton1.Checked == true)
            {
                Data.F = Data.F + 2;
            }
            //#19
            if (count == 19 && radioButton1.Checked == true && Data.pol == true)
            {
                Data.F = Data.F + 2;
            }
            else if (count == 19 && radioButton1.Checked == true && Data.pol == false)
            {
                Data.F = Data.F + 1;
            }
            //#23
            if (count == 23 && radioButton1.Checked == true)
            {
                Data.T = Data.T + 1;
            }
            //#27
            if (count == 27 && radioButton2.Checked == true && Data.pol == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 27 && radioButton2.Checked == true && Data.pol == true)
            {
                Data.T = Data.T + 2;
            }
            //#31,51
            if ((count == 31 || count == 51) && radioButton1.Checked == true)
            {
                Data.F = Data.F + 1;
            }
            else if ((count == 31 || count == 51) && radioButton2.Checked == true)
            {
                Data.T = Data.T + 2;
            }
            //#35,39
            if ((count == 35 || count == 39) && radioButton1.Checked == true)
            {
                Data.T = Data.T + 2;
            }
            else if ((count == 35 || count == 39) && radioButton2.Checked == true && Data.pol == true)
            {
                Data.F = Data.F + 2;
            }
            else if ((count == 35 || count == 39) && radioButton2.Checked == true && Data.pol == false)
            {
                Data.F = Data.F + 1;
            }
            //#43
            if (count == 43 && radioButton1.Checked == true && Data.pol == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 43 && radioButton1.Checked == true && Data.pol == false)
            {
                Data.T = Data.T + 2;
            }
            else if (count == 43 && radioButton2.Checked == true)
            {
                Data.F = Data.F + 2;
            }
            //#47
            if (count == 47 && radioButton1.Checked == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 47 && radioButton2.Checked == true)
            {
                Data.F = Data.F + 2;
            }
            //#55
            if (count == 55 && radioButton1.Checked == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 55 && radioButton2.Checked == true)
            {
                Data.F = Data.F + 1;
            }
            //#59
            if (count == 59 && radioButton1.Checked == true)
            {
                Data.T = Data.T + 1;
            }
            else if (count == 59 && radioButton2.Checked == true && Data.pol == true)
            {
                Data.F = Data.F + 2;
            }
            else if (count == 59 && radioButton2.Checked == true && Data.pol == false)
            {
                Data.F = Data.F + 1;
            }
            //#63,86
            if ((count == 63 || count == 86) && radioButton1.Checked == true)
            {
                Data.T += 2;
            }
            //#67,71,75
            if ((count == 67 || count == 71 || count == 75) && radioButton2.Checked == true)
            {
                Data.T += 2;
            }
            //#79
            if (count == 79 && radioButton2.Checked == true)
            {
                Data.T++;
            }
            //#83
            if (count == 83 && radioButton1.Checked == true)
            {
                Data.F++;
            }
            else if (count == 83 && radioButton2.Checked == true)
            {
                Data.T++;
            }
            //#89
            if (count == 89 && radioButton1.Checked == true)
            {
                Data.F++;
            }

            //end
            if (count == 94 && radioButton1.Checked == true)
            {
                Data.S++;
                this.Hide();
                LastForm lastform = new LastForm();
                lastform.Show();
            }
            else if (count == 94 && radioButton2.Checked == true)
            {
                Data.N++;
                this.Hide();
                LastForm lastform = new LastForm();
                lastform.Show();
            }
            if (count != 94)
            {
                count = count + 1;//счетчик
                label2.Text = "Вопрос " + count + " из 94";//меняет номер вопроса
                progressBar1.Value = count;//заполняемость бара
                label1.Text = quest[count];//вопрос
                radioButton1.Text = answer_a[count];//ответ а
                radioButton2.Text = answer_b[count];//ответ б
            }
/*            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            NextQuestButton.Enabled = false;*/
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NextQuestButton.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            NextQuestButton.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NextQuestButton.Enabled = true;
        }
    }
}
