﻿using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.Services
{
    public class UserAccountService : IAccountService
    {
        IUnitOfWork DataBase { get; set; }

        public UserAccountService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }

        public async Task<SignUpResultDTO> CreateUser(SignUpUserDTO signUpDTO)
        {
            ApplicationUser identityUser = new ApplicationUser()
            {
                UserName = signUpDTO.Username,
                Email = signUpDTO.Email
            };

            UserAccount user = new UserAccount()
            {
                IdentityUser = identityUser,
                Password = signUpDTO.Password
            };

            SignUpResultDTO resultDTO = new SignUpResultDTO()
            {
                Result = await DataBase.Accounts.CreateAsync(user)
            }; 

            if (resultDTO.Result.Succeeded)
            {
                UserProfile userProfile = new UserProfile()
                {
                    ApplicationUserId = user.IdentityUser.Id
                };

                DataBase.UserProfiles.Create(userProfile);
                DataBase.Save();

                var code = await DataBase.Accounts.GetEmailConfirmationToken(identityUser);

                resultDTO.VerificationCode = code;
                resultDTO.UserId = identityUser.Id;
                resultDTO.Email = identityUser.Email;
                resultDTO.Username = identityUser.UserName;
            }
            
            return resultDTO;         
        }

        public async Task<IdentityResult> ConfirmEmail(string userId, string code)
        {
            var user = await DataBase.Accounts.GetById(userId);

            if(user == null)
            {
                return null;
            }

            var result = await DataBase.Accounts.ConfirmEmailAsync(user, code);

            return result;
        }

        public async Task<SignInResult> SignInAsync(SignInUserDTO signInDTO)
        {
            bool RememberMeBool = false;

            if (signInDTO.RememberMe == "on")
            {
                RememberMeBool = true;
            }
            return await DataBase.Accounts.PasswordSignInAsync(signInDTO.Username, signInDTO.Password,
                                                               RememberMeBool);
        }

        public async Task SignOutAsync()
        {
            await DataBase.Accounts.SignOutAsync();
        }

    }
}
