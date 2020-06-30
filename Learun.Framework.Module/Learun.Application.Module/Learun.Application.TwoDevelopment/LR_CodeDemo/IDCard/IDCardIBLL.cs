﻿using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.LR_CodeDemo
{
    /// <summary>
    /// 创 建：超级管理员
    /// 日 期：2020-06-29 21:15
    /// 描 述：身份证管理
    /// </summary>
    public interface IDCardIBLL
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<tc_IDCardEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取tc_IDCard表实体数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        tc_IDCardEntity Gettc_IDCardEntity(string keyValue);
        /// <summary>
        /// 获取tc_Personnels表实体数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        tc_PersonnelsEntity Gettc_PersonnelsEntity(string keyValue);
        /// <summary>
        /// 获取左侧树形数据
        /// </summary>
        /// <returns></returns>
        List<TreeModel> GetTree(string PersonId, string ApplicantId);
        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="entity">实体</param>
        void SaveEntity(string keyValue, tc_IDCardEntity tc_IDCardEntity);
        #endregion

    }
}
