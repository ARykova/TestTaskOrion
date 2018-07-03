using System;
using System.Collections.Generic;
using System.IO;
using TestTaskOrion.DataAccessLayer;
using TestTaskOrion.Model;

namespace TestTaskOrion.DataAccess
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
                    Title = "Устранение неполадок",
                    Price = 500,
                    Description = "Выезд на дом"
                });
            services.Add(
                new Service
                {
                    Id = 2,
                    Title = "Устранение неполадок без выезда",
                    Price = 0,
                    Description = "Соединение со специалистом"
                });
            services.Add(
                new Service
                {
                    Id = 3,
                    Title = "Подключение",
                    Price = 0,
                    Description = "Выезд на дом"
                });
            services.Add(
                new Service
                {
                    Id = 3,
                    Title = "Изменение условий",
                    Price = 0,
                    Description = "Соединение со специалистом"
                });

            return services;
        }

        public List<Tariff> GetTariffs()
        {
            var tariffs = new List<Tariff>();
            tariffs.Add(
                new Tariff
                {
                    Id = 1,
                    Title = "Orion 450",
                    Price = 450,
                    DaySpeed = 50,
                    NightSpeed = 100,
                    Description = "БОНУС: Орион IPTV более 200 каналов"
                });
            tariffs.Add(
                new Tariff
                {
                    Id = 2,
                    Title = "Orion 300",
                    Price = 300,
                    DaySpeed = 15,
                    NightSpeed = 100,
                    Description = "БОНУС: Орион IPTV более 200 каналов"
                });
            tariffs.Add(
                new Tariff
                {
                    Id = 3,
                    Title = "Orion 600",
                    Price = 600,
                    DaySpeed = 80,
                    NightSpeed = 100,
                    Description = "БОНУС: Орион IPTV более 200 каналов"
                });

            return tariffs;

        }

        public bool SaveAppeal(Appeal appeal)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("\appeals.txt");
                streamWriter.Write($"Обращение №{appeal.Id} \n " +
                    $"{appeal.City} \n " +
                    $"{appeal.Surname} {appeal.Name} {appeal.Patronymic} \n" +
                    $"{appeal.Address} \n" +
                    $"{appeal.PhoneNumber} \n" +
                    $"{appeal.Reason} \n" +
                    $"{appeal.Comment}");
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
                StreamWriter streamWriter = new StreamWriter("\applications.txt");
                streamWriter.Write($"Заявка №{application.Id} по обращению №{application.Appeal.Id} \n " +
                    $"{application.Appeal.City} \n " +
                    $"{application.Appeal.Surname} {application.Appeal.Name} {application.Appeal.Patronymic} \n" +
                    $"{application.Appeal.Address} \n" +
                    $"{application.Appeal.PhoneNumber} \n" +
                    $"{application.Appeal.Reason} \n" +
                    $"{application.Appeal.Comment} \n" +
                    $"{application.Offer.Title} \n" +
                    $"{application._isFinished} \n" +
                    $"{application._earlyFinishReason} \n" +
                    $"{application._operatorComment}");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
