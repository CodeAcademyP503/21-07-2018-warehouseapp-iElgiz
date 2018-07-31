using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public static class LocalStorage
    {
        public static Form1 MainForm = new Form1();
        public static Markets[] marketss = new Markets[4];
        public static Workers[] workerss = new Workers[50];
        public static Markets GoMarket;
        public static Grade[] gr = new Grade[10];
        public static Markets gograde;

        public static int Count { get; set; } = 1;

        public static void CreateWorkers()
        {

            Grade grade1 = new Grade();
            grade1.gradeName = GrName.G01;
            gr[0] = grade1;

            Grade grade2 = new Grade();
            grade2.gradeName = GrName.G02;
            gr[1] = grade2;

            Grade grade3 = new Grade();
            grade3.gradeName = GrName.G02M;
            gr[2] = grade3;

            Grade grade4 = new Grade();
            grade4.gradeName = GrName.G02NS;
            gr[3] = grade4;


            Markets market1 = new Markets();
            market1.MarketName = MarketS.mango;
            marketss[0] = market1;
            market1.Grade = gr[0];
            

            Workers workers1 = new Workers();
            workers1.Name = "Elgiz";
            workers1.Surname = "Eyvazli";
            workers1.Mail = "elgiz1998@bk.ru";
            workers1.Status = MarketStatus.Manager;
            workers1.Wage = 700;
            workers1.WorkPlace = MarketS.mango;
            workers1.PassWord = "12345";
            workerss[0] = workers1;
            market1.workersss[0] = workers1;


            Workers workers2 = new Workers();
            workers2.Name = "Shahin";
            workers2.Surname = "Cabbarov";
            workers2.Mail = "ShahinCabbarov@bk.ru";
            workers2.Status = MarketStatus.ChiefRepresentative;
            workers2.Wage = 600;
            workers2.WorkPlace = MarketS.mango;
            workerss[1] = workers2;
            market1.workersss[1] = workers2;


            Workers workers3 = new Workers();
            workers3.Name = "Adigozel";
            workers3.Surname = "Khalilov";
            workers3.Mail = "AdigozelKhalilov@bk.ru";
            workers3.Status = MarketStatus.SalesAssistant;
            workers3.Wage = 500;
            workers3.WorkPlace = MarketS.mango;
            workerss[2] = workers3;
            market1.workersss[2] = workers3;



            Workers workers4 = new Workers();
            workers4.Name = "Atilla";
            workers4.Surname = "Rzazade";
            workers4.Mail = "AtillaRzazade@bk.ru";
            workers4.Status = MarketStatus.SalesRepresentative;
            workers4.Wage = 400;
            workers4.WorkPlace = MarketS.mango;
            workerss[3] = workers4;
            market1.workersss[3] = workers4;

            

            Markets market2 = new Markets();
            market2.MarketName = MarketS.bershka;
            marketss[1] = market2;
            market2.Grade = gr[1];

            Workers workers5 = new Workers();
            workers5.Name = "Baxish";
            workers5.Surname = "Baxishov";
            workers5.Mail = "BaxishBaxishov@bk.ru";
            workers5.Status = MarketStatus.Manager;
            workers5.Wage = 700;
            workers5.WorkPlace = MarketS.bershka;
            workers2.bonucetype = BonuceType.person;
            workers5.PassWord = "12345";
            workerss[4] = workers5;
            market2.workersss[0] = workers5;

            Workers workers6 = new Workers();
            workers6.Name = "Anella";
            workers6.Surname = "Miller";
            workers6.Mail = "AnellaMiller@bk.ru";
            workers6.Status = MarketStatus.ChiefRepresentative;
            workers6.Wage = 600;
            workers6.WorkPlace = MarketS.bershka;
            workerss[5] = workers6;
            market2.workersss[1] = workers6;

            Workers workers7 = new Workers();
            workers7.Name = "Fidan";
            workers7.Surname = "Rzayeva";
            workers7.Mail = "FidanRzayeva@bk.ru";
            workers7.Status = MarketStatus.SalesAssistant;
            workers7.Wage = 500;
            workers7.WorkPlace = MarketS.bershka;
            workerss[6] = workers7;
            market2.workersss[2] = workers7;


            Workers workers8 = new Workers();
            workers8.Name = "Ferid";
            workers8.Surname = "Memmedov";
            workers8.Mail = "FeridMemmedov@bk.ru";
            workers8.Status = MarketStatus.SalesRepresentative;
            workers8.Wage = 400;
            workers8.WorkPlace = MarketS.bershka;
            workerss[7] = workers8;
            market2.workersss[3] = workers8;

            

            

            Markets market3 = new Markets();
            market3.MarketName = MarketS.celio;
            marketss[2] = market3;
            market3.Grade = gr[2];


            Workers workers9 = new Workers();
            workers9.Name = "Kazim";
            workers9.Surname = "Memmedov";
            workers9.Mail = "KazimMemmedov@bk.ru";
            workers9.Status = MarketStatus.Manager;
            workers9.Wage = 700;
            workers9.WorkPlace = MarketS.celio;
            workers9.PassWord = "12345";
            workerss[8] = workers9;
            market3.workersss[0] = workers9;

            Workers workers10 = new Workers();
            workers10.Name = "Ferhad";
            workers10.Surname = "Shirinov";
            workers10.Mail = "FerhadShirinov@bk.ru";
            workers10.Status = MarketStatus.ChiefRepresentative;
            workers10.Wage = 600;
            workers10.WorkPlace = MarketS.celio;
            workers10.bonucetype = BonuceType.person;
            workerss[9] = workers10;
            market3.workersss[1] = workers10;

            Workers workers11 = new Workers();
            workers11.Name = "Rahima";
            workers11.Surname = "Khudratova";
            workers11.Mail = "AdigozelKhalilov@bk.ru";
            workers11.Status = MarketStatus.SalesAssistant;
            workers11.Wage = 500;
            workers11.WorkPlace = MarketS.celio;
            workers11.bonucetype = BonuceType.person;
            workerss[10] = workers11;
            market3.workersss[2] = workers11;


            Workers workers12 = new Workers();
            workers12.Name = "Aydan";
            workers12.Surname = "Shabanova";
            workers12.Mail = "AtillaRzazade@bk.ru";
            workers12.Status = MarketStatus.SalesRepresentative;
            workers12.Wage = 400;
            workers12.WorkPlace = MarketS.celio;
            workers12.bonucetype = BonuceType.cash;
            workerss[11] = workers12;
            market3.workersss[3] = workers12;

            

            Markets market4 = new Markets();
            market4.MarketName = MarketS.zara;
            marketss[3] = market4;
            market4.Grade = gr[3];

            Workers workers13 = new Workers();
            workers13.Name = "Anar";
            workers13.Surname = "Qasimov";
            workers13.Mail = "AnarQasimov@bk.ru";
            workers13.Status = MarketStatus.Manager;
            workers13.Wage = 700;
            workers13.WorkPlace = MarketS.zara;
            workers13.PassWord = "12345";
            workerss[12] = workers13;
            market4.workersss[0] = workers13;

            Workers workers14 = new Workers();
            workers14.Name = "Elshad";
            workers14.Surname = "Rustemov";
            workers14.Mail = "ElshadRustemov@bk.ru";
            workers14.Status = MarketStatus.ChiefRepresentative;
            workers14.Wage = 600;
            workers14.WorkPlace = MarketS.zara;
            workers14.bonucetype = BonuceType.person;
            workerss[13] = workers14;
            market4.workersss[1] = workers14;

            Workers workers15 = new Workers();
            workers15.Name = "Elbey";
            workers15.Surname = "Eyvazli";
            workers15.Mail = "ElbeyEyvazli@bk.ru";
            workers15.Status = MarketStatus.SalesAssistant;
            workers15.Wage = 500;
            workers15.WorkPlace = MarketS.zara;
            workers15.bonucetype = BonuceType.person;
            workerss[14] = workers15;
            market4.workersss[2] = workers15;


            Workers workers16 = new Workers();
            workers16.Name = "Sebuhi";
            workers16.Surname = "Rehimov";
            workers16.Mail = "SebuhiRehimov@bk.ru";
            workers16.Status = MarketStatus.SalesRepresentative;
            workers16.Wage = 400;
            workers16.WorkPlace = MarketS.zara;
            workers16.bonucetype = BonuceType.cash;
            workerss[15] = workers16;
            market4.workersss[3] = workers16;
        }

    }
}
