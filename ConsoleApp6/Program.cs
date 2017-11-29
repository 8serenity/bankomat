﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;
using AccountNamespace;
using ClientNamespace;

/*
        Реализовать классы Banc, Client, Account в различных пространствах имен
        (общее пространство имен «Bankomat»). Изначально клиенту нужно открыть счёт в банке,
        получить номер счёта, получить свой пароль, положить сумму на счёт.

    1.	        Приложение предлагает ввести пароль предполагаемой кредитной
                карточки, даётся 3 попытки на правильный ввод пароля. Если попытки
                исчерпаны, приложение выдаёт соответствующее сообщение и завершается.
    
    2.	        При успешном вводе пароля выводится меню. Пользователь может выбрать одно из нескольких действий:
                a.	вывод баланса на экран;
                b.	пополнение счёта;
                c.	снять деньги со счёта;
                d.	выход.
    
    3.	        Если пользователь выбирает вывод баланса на экран,
                приложение отображает состояние предполагаемого счёта, после чего
                предлагает либо вернуться в меню, либо совершить выход.
    
    4.	        Если пользователь выбирает пополнение счёта, программа
                запрашивает сумму для пополнения и выполняет операцию, сопровождая её
                выводом соответствующего комментария. Затем следует предложение вернуться в меню или выполнить выход.
    
    5.	        Если пользователь выбирает снять деньг со счёта, программа запрашивает сумму.
                Если сумма превышает сумму счёта пользователя, программа выдаёт сообщение и
                переводит пользователя в меню. Иначе отображает сообщение о том,
                что сумма снята со счёта и уменьшает сумму счёта на указанную величину.
     */

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public int AddAccount(Client client)
        {
            Account temp = new Account();
            client.GetAccounts().Add(temp);
            return client.GetAccounts()[client.GetAccounts().Count].GetAccountID();
        }



    }
}
