﻿using Domain.Dtos;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces
{
    public interface ICsvService
    {
        List<CsvDto> ReadFormFile(IFormFile file);
        Task<List<CsvDto>> ReadFormFileAync(string[] file);        
    }
}
