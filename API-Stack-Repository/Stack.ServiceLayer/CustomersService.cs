
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Stack.Core;
using Stack.DTOs;
using Stack.DTOs.Enums;
using Stack.DTOs.Models;
using Stack.DTOs.Requests;
using Stack.Entities.Models;
using Stack.Repository.Common;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Stack.ServiceLayer
{
    public class CustomersService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IConfiguration config;
        private readonly IMapper mapper;
        private static readonly HttpClient client = new HttpClient();


        public CustomersService(UnitOfWork unitOfWork, IConfiguration config, IMapper mapper , IOptions<MailSettings> mailSettings)
        {
            this.unitOfWork = unitOfWork;
            this.config = config;
            this.mapper = mapper;
        }

        public async Task<ApiResponse<List<CustomerDTO>>> GetAllCustomers()
        {
            ApiResponse<List<CustomerDTO>> result = new ApiResponse<List<CustomerDTO>>();
            try
            {
                var UsersListQuery = await unitOfWork.CustomerManager.GetAllCustomers();
                var Users = UsersListQuery.ToList();

                if (Users != null)
                {
                   
                    result.Succeeded = true;
                    result.Data = mapper.Map<List<CustomerDTO>>(Users);
                    return result;
                }
                else
                {
                    result.Succeeded = false;
                    result.Errors.Add("Failed to Find customers");
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Succeeded = false;
                result.Errors.Add(ex.Message);
                return result;
            }
        }

        
    }

}


