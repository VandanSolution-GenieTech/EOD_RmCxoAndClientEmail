﻿using DataService.Models;
using EOD_ClientEmail.DTOs;


namespace EOD_ClientEmail
{
    public interface IEODClientEmailservice
    {
        Task SendOrderEmailToClient();
        Task SendOrderMailToCxo();
    }
}
