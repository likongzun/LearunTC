﻿using Learun.Util;
using System.Data;
using Learun.Application.TwoDevelopment.LR_CodeDemo;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Learun.Application.Web.Areas.LR_CodeDemo.Controllers
{
    /// <summary>
    /// 创 建：超级管理员
    /// 日 期：2020-07-10 18:11
    /// 描 述：项目详情
    /// </summary>
    public class ProjectDetailController : MvcControllerBase
    {
        private ProjectDetailIBLL projectDetailIBLL = new ProjectDetailBLL();

        #region 视图功能

        /// <summary>
        /// 主页面
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
             return View();
        }
        /// <summary>
        /// 表单页
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Form()
        {
             return View();
        }
        #endregion

        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        [HttpGet]
        
        public ActionResult GetPageList(string pagination, string queryJson)
        {
            Pagination paginationobj = pagination.ToObject<Pagination>();
            var data = projectDetailIBLL.GetPageList(paginationobj, queryJson);
            var jsonData = new
            {
                rows = data,
                total = paginationobj.total,
                page = paginationobj.page,
                records = paginationobj.records
            };
            return Success(jsonData);
        }
        /// <summary>
        /// 获取表单数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpGet]
        
        public ActionResult GetFormData(string keyValue)
        {
            var tc_ProjectDetailData = projectDetailIBLL.Gettc_ProjectDetailEntity( keyValue );
            var jsonData = new {
                tc_ProjectDetail = tc_ProjectDetailData,
            };
            return Success(jsonData);
        }
        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        
        public ActionResult DeleteForm(string keyValue)
        {
            projectDetailIBLL.DeleteEntity(keyValue);
            return Success("删除成功！");
        }
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="strEntity">实体</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult SaveForm(string keyValue, string strEntity)
        {
            tc_ProjectDetailEntity entity = strEntity.ToObject<tc_ProjectDetailEntity>();
            projectDetailIBLL.SaveEntity(keyValue,entity);
            if (string.IsNullOrEmpty(keyValue))
            {
            }
            return Success("保存成功！");
        }



        [HttpGet]
        public ActionResult GetPageListByProjectId(string ProjectId)
        {
            var data = projectDetailIBLL.GetPageListByProjectId(ProjectId);
            return Success(data);
        }


        #endregion

    }
}
