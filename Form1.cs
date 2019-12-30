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
    public partial class Form1 : Form
    {
        Question[] questions;
        int questionIndex = 0;
        int trueCount = 0;
        int wrongCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillQuestions();
            FillLabelsAndButtons(questionIndex);

            lblQuestionCount.Text = questions.Length.ToString();
        }

        void FillQuestions()
        {
            questions = new Question[]
            {
                new Question(
                    "Tevhid-i Tedrisat Kanunu ile gerçekleştirilmek istenen aşağıdakilerden hangisidir?",

                    new string[]{
                        "A) Eğitim işlerinin tek elden yönetilmesi",
                        "B) Halkın eğitime katkısının artırılması",
                        "C) Azınlık okullarının sayısınının sınırlandırılması",
                        "D) Devletin ekonomik yükünün azaltılması",
                        "E) Mesleki eğitimin özendirilmesi",
                    },

                    0
                ),
                new Question(
                    "I. Hatay Sorunu \n" +
                    "II. Boğazlar Sorunu \n" +
                    "III Musul Sorunu \n \n" +
                    "Yukarıdaki meselelerden hangisi/hangileri Atatürk'ün vefatından sonra çözüme kavuşturulmuştur?",

                    new string[]{
                        "A) Yalnız III",
                        "B) I ve II",
                        "C) Yalnız I",
                        "D) Yalnız II",
                        "E) I, II ve III",
                    },

                    2
                ),
                new Question(
                    "Sevr Antlaşması'na göre; Osmanlı Devleti'nde zorunlu askerlik kaldırılacaktı \n" +
                    "Bu karar, İtilaf devletlerinin aşağıdakilerden hangisini gerçekleştirmek istediğinin kanıtıdır?",

                    new string[]{
                        "A) Saltanatın devamını sağlamak",
                        "B) Osmanlı ordusunun modern hale gelmesine yardımcı olmak",
                        "C) Üretim alanında çalışacak insan sayısını arttırmak",
                        "D) Osmanlı Devleti'nin savunma gücünü yok etmek",
                        "E) Genç nüfusun ekonomide çalışmasına ortam hazırlamak",
                    },

                    3
                ),
                new Question(
                    "Aşağıdakilerden hangisi Mudanya Mütarekesi'nin özellikleri arasında yer almaz?",

                    new string[]{
                        "A) Lozan Antlaşması'na zemin hazırlamıştır",
                        "B) Batı Trakya TBMM'ye bırakılmıştır",
                        "C) Kurtuluş Savaşı'nın sonunu getirmiştir",
                        "D) Doğu Trakya savaşsız ele geçirilmiştir",
                        "E) İtilaf Devletleri ile TBMM arasında imzalanmıştır",
                    },

                    2
                ),
                new Question(
                    "Aşağıdaki ayaklanmalardan hangisinin amacı, Anadolu'daki Milli Mücadele hareketini durdurmak veya işgalleri kolaylaştırmak değildir?",

                    new string[]{
                        "A) Anzavur ayaklanması",
                        "B) Afyon ayaklanması",
                        "C) Kuva-yı İnzibatiye ayaklanması",
                        "D) Çerkez Ethem ayaklanması",
                        "E) Yozgat ayaklanması",
                    },

                    3
                ),
                new Question(
                    "TBMM'nin ilk siyasi başarısı ve Sevr Antlaşması'nın geçersizliğinin ilk belgesi olan Gümrü Antlaşması Ermenistan ile imzalanmıştır.\n" +
                    "Gümrü Antlaşması'nın sonuçları ile ilgili olarak aşağıdakilerden hangisi söylenemez?",

                    new string[]{
                        "A) İtilaf devletleri Sevr Antlaşması'nda değişiklik önerisi getirmiştir",
                        "B) Ermeni sorunu hukuken sona ermiştir",
                        "C) Moskova Antlaşması'nın imzalanmasına zemin hazırlamıştır",
                        "D) Misak-ı Milli'nin Doğu Anadolu ile ilgili maddelerinin bir bölümü gerçekleşmiştir",
                        "E) Doğu sınırının belirlenmesinde etkili olmuştur",
                    },

                    2
                ),
                new Question(
                    "Türkiye Cumhuriyeti Devleti'nin, Milletler Cemiyetinin büyük devletlerinin çıkarlarına hizmet eden bir kuruluş haline geldiğini bilmesine rağmen\n" +
                    "bu cemiyete üye olmasının temel amacı aşağıdakilerden hangisi olabilir?",

                    new string[]{
                        "A) Sınırlarının güvenliğini sağlamak",
                        "B) Büyük devletlerin dostluğunu kazanmak",
                        "C) Ege adaları meslesine çözüm bulmak",
                        "D) Barış yanlısı bir devlet olduğunu göstermek",
                        "E) RUsya'nın saldırgan politikasını önlemek",
                    },

                    3
                ),
                new Question(
                    "Türk Hükümeti Lozan görüşmelerinde Ermeni meslesi ve kapitülasyonlar konusunda anlaşmaya varılamaz ise görüşmelerin kesilmesini, barışın imzasından vazgeçilmesini kararlaştırmıştır.\n" +
                    "Ermeni meselesi ve kapitülasyonlar hangi yönleri nedeniyle taviz verilmeyecek konular arasında sayılmıştır?",

                    new string[]{
                        "A) Tam bağımsızlığımızı engellemeleri",
                        "B) Diğer konulara etki etmeleri",
                        "C) Ermeni isyanlarına engel olunmak istenmesi",
                        "D) Ekonomik açıdan tehlikeli olmaları",
                        "E) İtilaf devletlerinin barışa ikna edilmesine yol açmaları",
                    },

                    0
                ),
                new Question(
                    "Atatürk'ün Türk demek dil demektir. Türk milletindenim diyen insanlar her şeyden önce mutlaka Türkçe konuşmalıdır. sözlerinin aşağıdaki ilkelerden hangisili ile bağlantılı olduğu söylenebilir?",

                    new string[]{
                        "A) Cumhuriyetçilik",
                        "B) Milliyetçilik",
                        "C) Laiklik",
                        "D) Halkçılık",
                        "E) Devletçilik",
                    },

                    1
                ),
                new Question(
                    "Aşağıdakilerden hangisi Sakarya Muharebesi'nin sonuçları arasında yer almaz?",

                    new string[]{
                        "A) Fransa ile Ankara Antlaşması imzalanmıştır",
                        "B) Kafkas Cumhuriyetleriyle Kars Antlaşması imzanalanmıştır",
                        "C) Savaş sonunda Yunanlılar savunmaya geçmiştir",
                        "D) İtalya Yunanlılar'ın yanında yer almıştır",
                        "E) İngiltere Yunanlılara olan desteğini çekmeye başlamıştır",
                    },

                    3
                ),
                new Question(
                    "1 Temmuz 1926'da uygulanmaya başlanan Kabotaj Kanunu'nda Türk denizlerinde gemi işletme hakkının yalnız Türkiye Cumhuriyeti Devleti'ne ait olacağı belirtilmiştir.\n" +
                    "Kabotaj Kanunu, Osmanlı Devleti döneminde görülen aşağıdaki uygulamalardan hangisine karşı çıkarılmıştır?",

                    new string[]{
                        "A) Ruslara, Ortodoks halık himaye hakkının tanınmasına",
                        "B) Yabancılara tanınan ekonomik ve siyasal ayrıcalıklara",
                        "C) Azınlıklara ülke yönetimine katılma hakkı tanınmasına",
                        "D) Azınlıklara hoşgörü ile davranılmasına",
                        "E) Hristiyanlara devlet memuru olabilme hakkı verilmesine",
                    },

                    1
                ),
                new Question(
                    "Kurtuluş Savaşı sonrası yapılan inkılaplar arasında takvim ve saat sistemindeki değişiklikler de yer almaktadır\n" +
                    "Bu değişikliklerin amacı aşağıdakilerden hagisidir?",

                    new string[]{
                        "A) İnkılaplar arasında uyum sağlamak",
                        "B) Batılı güçlü devletlerin desteğini sağlamak",
                        "C) Geriye dönüş yolunu kapamak",
                        "D) Batıya hoş görünmek",
                        "E) Uluslararası ilişkileri kolaylaştırmak",
                    },

                    4
                ),
                new Question(
                    "Balkan Antantı'nın kurulmasında aşağıdakilerden hangisinin etkisi olduğu savunulabilir?",

                    new string[]{
                        "A) Hatay'ın Türkiye topraklarına katılması",
                        "B) Sadabat Paktı'nın yapılması",
                        "C) Sovyet Rusya'sının boğazlar üzerindeki istekleri",
                        "D) Birinci Dünya Savaşı'nın başlaması",
                        "E) İtalya ve Almanya'nın saldırgan politikaları izlemeye başlaması",
                    },

                    4
                ),
                new Question(
                    "Atatürk aşağıdakilerden hangisini bir iç sorun haline getirip kesin olarak çözüme kavuşturmak için büyük çaba harcamıştır?",

                    new string[]{
                        "A) Musul Sorunu",
                        "B) Hatay Sorunu",
                        "C) Yabancı Okullar Sorunu",
                        "D) Boğazlar Sorunu",
                        "E) Nüfus Mübadelesi",
                    },

                    1
                ),
                new Question(
                    "Mondros'tan sonra Anadolu'nun işgal edilmesi üzerine işgalcilere karşı Türk halkının oluşturduğu milli kuvvetlere ne ad verilmiştir?",

                    new string[]{
                        "A) Kuva-yı Milliye",
                        "B) Kanun-i Esasi",
                        "C) Misak-ı Milli",
                        "D) Müdaafa-i Hukuk",
                        "E) Teşkilat-ı Esasiye",
                    },

                    0
                ),
                new Question(
                    "Aşağıdakilerden hangisi, Osmanlı Devleti'nin Balkan Savaşları sonun kaybettiği yerlerden biri değildir?",

                    new string[]{
                        "A) Batı Trakya",
                        "B) Bosna-Hersek",
                        "C) Arnavutluk",
                        "D) Makedonya",
                        "E) Ege Adaları",
                    },

                    2
                ),
                new Question(
                    "Nizam-ı Cedit ordusunun kurulması, irad-ı cedid adıyla gelir kaynaklarının oluşturulması, ordunun batılı tarzda modernizasyonu için batıdan uzmanlar getirilmesi hangi padişah döneminde gerçekleşmiştir?",

                    new string[]{
                        "A) IV. Murat",
                        "B) II. Abdülhamit",
                        "C) II. Mahmud",
                        "D) Abdülmecit",
                        "E) III. Selim",
                    },

                    4
                ),
                new Question(
                    "Aşağıdakilerden ülkelerden hangisi Balkan Antantı'na katılmamıştır?",

                    new string[]{
                        "A) Romanya",
                        "B) Yugoslavya",
                        "C) Bulgaristan",
                        "D) Yunanistan",
                        "E) Türkiye",
                    },

                    2
                ),
                new Question(
                    "Aşağıdakilerden hangisi Osmanlı Devleti'nin I. Dünya Savaşı sırasında müttefiklerine yardım etmek amacı ile savaştığı cephelerden biridir?",

                    new string[]{
                        "A) Çanakkale Cephesi",
                        "B) Kanal Cephesi",
                        "C) Irak Cephesi",
                        "D) Kafkas Cephesi",
                        "E) Galiçya Cephesi",
                    },

                    4
                ),
                new Question(
                    "Aşağıdakilerden hangisi Çanakkale Savaşı'nın sonuçlarından değildir?",

                    new string[]{
                        "A) Rusya'daki bunalımın artması",
                        "B) Dünya Savaşı'nın uzaması",
                        "C) Bulgaristan'ın Almanya yanında savaşa girmesi",
                        "D) İngiltere ve Fransa'nın isteklerine ulaşamaması",
                        "E) Osmanlı Devleti'nin savaş dışı bırakılması",
                    },

                    4
                ),
                new Question(
                    "Türkçülük, I. Dünya Savaşı Dönemi'nde hangi akım olarak ortaya atılmıştır?",

                    new string[]{
                        "A) Osmanlıcılık",
                        "B) İslamcılık",
                        "C) Batıcılık",
                        "D) Turancılık",
                        "E) Panislavizm",
                    },

                    3
                ),
                new Question(
                    "Laikliğin gerçekleştirilmesi yolunda atılan ilk adım, aiağıdakilerden hangisidir?",

                    new string[]{
                        "A) Medeni Kanun'un kabulü",
                        "B) Saltanatın kaldırılması",
                        "C) Medreselerin kapatılması",
                        "D) Cumhuriyetin ilan edilmesi",
                        "E) Harf İnkılabı",
                    },

                    0
                ),
                new Question(
                    "Lozan'da Nüfus Mübadelesi kararının alınmasının temel amacı aşağıdakilerden hangisidir?",

                    new string[]{
                        "A) Yunanistan'da yaşayan TÜrkleri Batı Trakya'da toplamak",
                        "B) Rumlar arasında birlik ve beraberlik sağlamak",
                        "C) Türkiye'nin milli bir devlet olduğunu göstermek",
                        "D) İleride azınlık sorunlarının doğmasını önlemek",
                        "E) Türk-Yunan dostluğunu sağlamak",
                    },

                    3
                ),
                new Question(
                    "Aşağıdaki kongrelerden hangilerinde İzmir'in işgalinden sonra Batı Anadolu'da oluşan Kuva-i Milliye birliklerinin etkinliğini artırmak amacıyla kararlar alınmıştır?",

                    new string[]{
                        "A) Balıkesir ve Alaşehir kongreleri",
                        "B) Erzurum ve Sivas Kongreleri",
                        "C) Amasya Görüşmeleri",
                        "D) Havza ve Amasya Genelgeleri",
                        "E) Fatih ve Sultan Ahmet mitingleri",
                    },

                    1
                ),
                new Question(
                    "Vahdettin 17 Kasım 1922'de saltanatın kaldrırıldığını kabul ederek İngiltere'ye sığınmıştır. İngiltere, Lozan Konferansı öncesinde,\n" +
                    "TBMM hükümetini hem içeride hem de dışarıda güç durumda bırakmak amacıyla Dünya Müslümanlarının dinsel liderinin İngiltere koruması altında\n" +
                    "olduğu propagandasına ağırlıl vermiştir.\n\n" +
                    "TBBMM bu propagandanın önüne geçebilmek için aşağıdaki önlemlerden hangisine öncelikle başvurmuştur?",

                    new string[]{
                        "A) Devletin rejiminin adını koymaya",
                        "B) TBMM'yi yenilemeye",
                        "C) Abdülmecit'i halifeliğe getirerek halifelik sorununu çözmeye",
                        "D) Devlet başkanlığı bunalımını aşmaya",
                        "E) Meclis Hükümeti sisteminden Kabine sistemine geçmeye",
                    },

                    2
                 ),
                  new Question(
                    "Atatürk dönemi dış politikasının ikinci bölümünde (1930-38) bölgede barış ve güvenliğin sağlanması amaçlanmıştır. Bu düşüncenin temel nedeni aşağıdakilerden hangisidir?",

                    new string[]{
                        "A) Suriye sınırının belirlenmemiş olması",
                        "B) İnkılapların yapılmasını hızlandırmak",
                        "C) Milletler Cemiyeti'ne girilmek istenmesi",
                        "D) İkinci Dünya Savaşı ihtimalinin belirlenmesi",
                        "E) Ekonomik kalkınmaya ağırlık verilmesi",
                    },

                    3
                  ),
                   new Question(
                    "Kurtuluş Savaşı'nın hazırlık döneminde ilk kez Erzurum Kongresi'nde yer alan manda, himaye kabul edilemez kararı ile aşağıdakilerden hangisi amançlanmıştır?",

                    new string[]{
                        "A) Halifenin desteğinin sağlanması",
                        "B) Kesin bağımsızlığın sağlanması",
                        "C) İtilaf Devletleri'nin desteğinin alınması",
                        "D) Osmanlı Hükümeti'nin desteğinin sağlanması",
                        "E) Azınlıkların çıkarlarının korunması",
                    },

                    1
                ),
                   new Question(
                    "1926 yılında, Mekteb-i Sanay-i Nefise-i Şahanenin Güzel Sanatlar Akademisine dönüştürülmesi, Atatürk'ün hangi ilkesinin uygulandığına kanıt olabilir?",

                    new string[]{
                        "A) İnkılapçılığın",
                        "B) Laikliğin",
                        "C) Milliyetçiliğin",
                        "D) Cumhuriyetçiliğin",
                        "E) Devletçiliğin",
                    },

                    0
                ),
            };
        }

        void FillLabelsAndButtons(int questionIndex)
        {
            lblQuestion.Text = questions[questionIndex].QuestionText;

            btnA.Text = questions[questionIndex].Answers[0];
            btnB.Text = questions[questionIndex].Answers[1];
            btnC.Text = questions[questionIndex].Answers[2];
            btnD.Text = questions[questionIndex].Answers[3];
            btnE.Text = questions[questionIndex].Answers[4];
        }

        void ButtonEnabledControl(bool isEnabled)
        {
            btnA.Enabled = isEnabled;
            btnB.Enabled = isEnabled;
            btnC.Enabled = isEnabled;
            btnD.Enabled = isEnabled;
            btnE.Enabled = isEnabled;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionIndex++;
            FillLabelsAndButtons(questionIndex);
            ButtonEnabledControl(true);
            lblCountOfQuestion.Text = (questionIndex + 1) + " )";

            btnA.BackColor = Color.FromArgb(224, 224, 224);
            btnB.BackColor = Color.FromArgb(224, 224, 224);
            btnC.BackColor = Color.FromArgb(224, 224, 224);
            btnD.BackColor = Color.FromArgb(224, 224, 224);
            btnE.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ButtonEnabledControl(false);
            btnA.BackColor = Color.Red;
            switch (questions[questionIndex].TrueAnswerIndex)
            {
                case 0:
                    btnA.BackColor = Color.Green;
                    trueCount++;
                    break;
                case 1:
                    btnB.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 2:
                    btnC.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 3:
                    btnD.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 4:
                    btnE.BackColor = Color.Green;
                    wrongCount++;
                    break;
            }
            if (questionIndex >= (questions.Length - 1))
                btnNext.Enabled = false;
            lblTrueQuestionCount.Text = trueCount.ToString();
            lblWrongQuestionCount.Text = wrongCount.ToString();

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ButtonEnabledControl(false);
            btnB.BackColor = Color.Red;
            switch (questions[questionIndex].TrueAnswerIndex)
            {
                case 0:
                    btnA.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 1:
                    btnB.BackColor = Color.Green;
                    trueCount++;
                    break;
                case 2:
                    btnC.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 3:
                    btnD.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 4:
                    btnE.BackColor = Color.Green;
                    wrongCount++;
                    break;
            }

            if (questionIndex >= (questions.Length - 1))
                btnNext.Enabled = false;
            lblTrueQuestionCount.Text = trueCount.ToString();
            lblWrongQuestionCount.Text = wrongCount.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ButtonEnabledControl(false);
            btnC.BackColor = Color.Red;
            switch (questions[questionIndex].TrueAnswerIndex)
            {
                case 0:
                    btnA.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 1:
                    btnB.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 2:
                    btnC.BackColor = Color.Green;
                    trueCount++;
                    break;
                case 3:
                    btnD.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 4:
                    btnE.BackColor = Color.Green;
                    wrongCount++;
                    break;
            }
            if (questionIndex >= (questions.Length - 1))
                btnNext.Enabled = false;
            lblTrueQuestionCount.Text = trueCount.ToString();
            lblWrongQuestionCount.Text = wrongCount.ToString();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ButtonEnabledControl(false);
            btnD.BackColor = Color.Red;
            switch (questions[questionIndex].TrueAnswerIndex)
            {
                case 0:
                    btnA.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 1:
                    btnB.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 2:
                    btnC.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 3:
                    btnD.BackColor = Color.Green;
                    trueCount++;
                    break;
                case 4:
                    btnE.BackColor = Color.Green;
                    wrongCount++;
                    break;
            }
            if (questionIndex >= (questions.Length - 1))
                btnNext.Enabled = false;
            lblTrueQuestionCount.Text = trueCount.ToString();
            lblWrongQuestionCount.Text = wrongCount.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            ButtonEnabledControl(false);
            btnE.BackColor = Color.Red;
            switch (questions[questionIndex].TrueAnswerIndex)
            {
                case 0:
                    btnA.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 1:
                    btnB.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 2:
                    btnC.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 3:
                    btnD.BackColor = Color.Green;
                    wrongCount++;
                    break;
                case 4:
                    btnE.BackColor = Color.Green;
                    trueCount++;
                    break;
            }
            if (questionIndex >= (questions.Length - 1))
                btnNext.Enabled = false;
            lblTrueQuestionCount.Text = trueCount.ToString();
            lblWrongQuestionCount.Text = wrongCount.ToString();
        }
    }
}
