using System;
using System.Collections.Generic;
using System.IO;
using TestTaskOrion.DataAccessLayer;
using TestTaskOrion.Model;

namespace TestTaskOrion.DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        public List<Service> GetServices()
        {
            var services = new List<Service>();
            services.Add(
                new Service
                {
                    Id = 1,
                    Title = "Интернет",
                    Tariffs = SetInternetTariffs()  
                });

            services.Add(
                new Service
                {
                    Id = 2,
                    Title = "Телевидение",
                    Tariffs = SetTVTariffs()
                });

            services.Add(
                new Service
                {
                    Id = 3,
                    Title = "Пакет услуг",
                    Tariffs = SetComplexTariffs()
                });

            return services;
        }

        public List<ITariff> SetInternetTariffs()
        {
            var internetTarifs = new List<ITariff>();
            internetTarifs.Add(new InternetTariff
            {
                Id = 1,
                Title = "Orion 450",
                Price = 450,
                DaySpeed = 50,
                NightSpeed = 100,
                Description = "БОНУС: Орион IPTV более 200 каналов",
                ServiceId = 1
            });

            internetTarifs.Add(new InternetTariff
            {
                Id = 1,
                Title = "Orion 300",
                Price = 300,
                DaySpeed = 15,
                NightSpeed = 100,
                Description = "БОНУС: Орион IPTV более 200 каналов",
                ServiceId = 1
            });

            internetTarifs.Add(new InternetTariff
            {
                Id = 1,
                Title = "Orion 600",
                Price = 600,
                DaySpeed = 80,
                NightSpeed = 100,
                Description = "БОНУС: Орион IPTV более 200 каналов",
                ServiceId = 1
            });

            return internetTarifs;
        }

        public List<ITariff> SetTVTariffs()
        {
            var tvTarifs = new List<ITariff>();
            tvTarifs.Add(new TVTariff
            {
                Id = 4,
                Title = "Мегаполис",
                Price = 150,
                ChannelsCount = 70,
                Description = "БОНУС: Орион IPTV более 200 каналов",
                ServiceId = 2
            });

            tvTarifs.Add(new TVTariff
            {
                Id = 5,
                Title = "Мегаполис П",
                Price = 100,
                ChannelsCount = 70,
                Description = "БОНУС: Орион IPTV более 200 каналов",
                ServiceId = 2
            });

            return tvTarifs;
        }

        public List<ITariff> SetComplexTariffs()
        {
            var complexTariffs = new List<ITariff>();
            complexTariffs.Add(new ComplexTariff
            {
                Id = 6,
                Title = "Orion Express 500",
                Price = 500,
                Description = "Интернет: СКОРОСТЬ: 50 Мбит/с, СКОРОСТЬ НОЧЬЮ: 100 Мбит / с, ТВ: Группа каналов Пробки онлайн",
                ServiceId = 3
            });

            complexTariffs.Add(new ComplexTariff
            {
                Id = 6,
                Title = "Orion Combo TV 900",
                Price = 900,
                Description = "Интернет: СКОРОСТЬ: 100 Мбит/с, СКОРОСТЬ НОЧЬЮ: 100 Мбит / с, ТВ: Группа каналов Пробки онлайн",
                ServiceId = 3
            });

            return complexTariffs;
        }

        public bool SaveAppeal(Appeal appeal)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("D:\\appeals.txt");
                streamWriter.Write($"Обращение №{appeal.Id} \n " +
                    $"{appeal.City} \n " +
                    $"{appeal.Surname} {appeal.Name} {appeal.Patronymic} \n" +
                    $"{appeal.Address} \n" +
                    $"{appeal.PhoneNumber} \n" +
                    $"{appeal.Reason} \n" +
                    $"{appeal.Comment}");
                streamWriter.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveApplication (Application application)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("D:\\applications.txt");
                streamWriter.Write($"Заявка №{application.Id} по обращению №{application.Appeal.Id} \n " +
                    $"{application.Appeal.City} \n " +
                    $"{application.Appeal.Surname} {application.Appeal.Name} {application.Appeal.Patronymic} \n" +
                    $"{application.Appeal.Address} \n" +
                    $"{application.Appeal.PhoneNumber} \n" +
                    $"{application.Appeal.Reason} \n" +
                    $"{application.Appeal.Comment} \n" +
                    $"{application.ChosenService.Title} {application.ChosenTariff.Title}\n" +
                    $"{application._isFinished} \n" +
                    $"{application._earlyFinishReason} \n" +
                    $"{application._operatorComment}");
                streamWriter.Close();
                return true;
            }
            catch (Exception e )
            {
                var t = e.Message;
                return false;
            }
        }
    }
}
