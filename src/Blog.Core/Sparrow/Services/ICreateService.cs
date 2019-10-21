﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface ICreateService<TEntity, TKey, TCreateDTO, TDTO>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="createDTO"></param>
        /// <returns></returns>
        TDTO Create(TCreateDTO createDTO);

        /// <summary>
        /// 异步新增实体
        /// </summary>
        /// <param name="createDTO"></param>
        /// <returns></returns>
        Task<TDTO> CreateAsync(TCreateDTO createDTO);

        /// <summary>
        /// 新增实体并返回唯一标识
        /// </summary>
        /// <param name="createDTO"></param>
        /// <returns></returns>
        TKey CreateAndGetId(TCreateDTO createDTO);

        /// <summary>
        /// 异步新增实体并返回唯一标识
        /// </summary>
        /// <param name="createDTO"></param>
        /// <returns></returns>
        Task<TKey> CreateAndGetIdAsync(TCreateDTO createDTO);

        /// <summary>
        /// 新增多个实体
        /// </summary>
        /// <param name="createDTOs"></param>
        /// <returns></returns>
        void CreateMany(IEnumerable<TCreateDTO> createDTOs);

        /// <summary>
        /// 新增多个实体
        /// </summary>
        /// <param name="createDTOs"></param>
        /// <returns></returns>
        Task CreateManyAsync(IEnumerable<TCreateDTO> createDTOs);
    }
}