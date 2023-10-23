﻿using System.Threading.Tasks;
using System.Collections.Generic;
using Shamsheer.Service.DTOs.UserAssets;
using Shamsheer.Service.Configurations;

namespace Shamsheer.Service.Interfaces.UserAssets;

public interface IUserAssetService
{
    Task<bool> RemoveAsync(long id);
    Task<UserAssetForResultDto> RetrieveByIdAsync(long userId, long id);
    Task<UserAssetForResultDto> CreateAsync(UserAssetForCreationDto dto);
    Task<IEnumerable<UserAssetForResultDto>> RetrieveAllAsync(PaginationParams @params, long userId);
}