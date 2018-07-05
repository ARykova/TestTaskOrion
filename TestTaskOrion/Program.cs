using System;
using TestTaskOrion.DataAccessLayer;
using TestTaskOrion.Model;

namespace TestTaskOrion
{
    class Program
    {
        static void FinishApplication(Application application)
        {
            Console.WriteLine("Укажите причину завершения: 1. Отмена заявки 2. Решено оператором ");
            int reason = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Комментарий: ");
            application.SetEarlyFinish((Application.EarlyFinishReason)reason, Console.ReadLine());
        }

        static void Main(string[] args)
        {
            DataAccess data = new DataAccess();
            var services = data.GetServices();
            var appeal = new Appeal();

            Console.WriteLine("Фиксирование обращения\n");

            Console.WriteLine("Город: ");
            appeal.City = Console.ReadLine();

            Console.WriteLine("ФИО: ");
            var fio = Console.ReadLine().Split(" ");
            appeal.Surname = fio[0];
            appeal.Name = fio[1];
            appeal.Patronymic = fio[2];

            Console.WriteLine("Адрес: ");
            appeal.Address = Console.ReadLine();

            Console.WriteLine("Причина: \n 1. Первое подключение \n 2. Сбои \n 3. Изменение условий \n 4. Оплата, \n 5. Другое (введите цифру)");
            appeal.Reason = (Appeal.AppealReason)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Комментарий: ");
            appeal.Comment = Console.ReadLine();

            Console.WriteLine("Номер телефона: ");
            appeal.PhoneNumber = Console.ReadLine();

            data.SaveAppeal(appeal);

            var application = new Application();
            application.Id = 1;
            application.Appeal = appeal;

            Console.WriteLine("Выберите услугу: \n Для завершения заявки нажмите 0");

            foreach(Service service in services)
            {                
                Console.WriteLine($"{service.Id}. {service.Title}");
                Console.WriteLine(service.Description);
            }

            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    {
                        FinishApplication(application);
                        break;
                    }
                default:
                    {
                        application.ChosenService = services[choose-1];
                        Console.WriteLine("Выберите тариф: \n Для завершения заявки нажмите 0");
                        foreach (ITariff tariff in application.ChosenService.Tariffs)
                        {
                            Console.WriteLine($"{application.ChosenService.Tariffs.IndexOf(tariff)+1}. {tariff.Title}\n {tariff.Description} \n {tariff.Price}");
                        }

                        int chosenIdTarif = Convert.ToInt32(Console.ReadLine());
                        switch (chosenIdTarif)
                        {
                            case 0:
                                {
                                    application.ChosenTariff = new ComplexTariff();
                                    FinishApplication(application);
                                    break;
                                }
                            default:
                                {
                                    application.ChosenTariff = services[choose-1].Tariffs[chosenIdTarif-1];
                                    break;
                                }
                        }
                        break;
                    }
            }

            if (application._isFinished)
            {
                Console.WriteLine($"Заявка номер {application.Id} \n по обращению номер {application.Appeal.Id} " +
                    $"от {application.Appeal.Surname} {application.Appeal.Name} {application.Appeal.Patronymic} " +
                    $"завершена по причине {application._earlyFinishReason}");
            }
            else
            {
                Console.WriteLine("Информация о заявке:");
                Console.WriteLine($"Заявка номер {application.Id} \n по обращению номер {application.Appeal.Id} " +
                    $"от {application.Appeal.Surname} {application.Appeal.Name} {application.Appeal.Patronymic}" +
                    $"Выбранная услуга и тариф {application.ChosenService.Title} {application.ChosenTariff.Title} ");
                Console.WriteLine("Для сохранения заявки и передачи супервайзеру введите 1, для завершения 0");
                int save = Convert.ToInt32(Console.ReadLine());
                if (save == 0)
                {
                    FinishApplication(application);
                    Console.WriteLine($"Заявка номер {application.Id} \n по обращению номер {application.Appeal.Id} " +
                    $"от {application.Appeal.Surname} {application.Appeal.Name} {application.Appeal.Patronymic} " +
                    $"завершена по причине {application._earlyFinishReason}");
                }
                else
                {                    
                    Console.WriteLine("Заявка передана супервайзеру");
                }          
            }

            data.SaveApplication(application);
            Console.WriteLine("Заявка сохранена");
            Console.ReadKey();
        }

        
    }
}
