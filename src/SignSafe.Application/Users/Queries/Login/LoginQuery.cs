﻿using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SignSafe.Application.Users.Queries.Login
{
    public class LoginQuery : IRequest<LoginQueryResponse>
    {
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
