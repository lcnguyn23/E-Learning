using ELearning.Business;
using ELearning.Business.Services.Implementations;
using ELearning.Business.Services.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ELearning.Web.AppCodes
{
    /// <summary>
    /// 
    /// </summary>
    public class SelectListHelper
    {
        private readonly ITopicRepository _topicRepository;
        private readonly ILevelRepository _levelRepository;

        public SelectListHelper(ITopicRepository topicRepository, ILevelRepository levelRepository)
        {
            _topicRepository = topicRepository;
            _levelRepository = levelRepository;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SelectListItem>> TopicSelectList()
        {
            var topics = await _topicRepository.GetAllAsync();
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var topic in topics)
            {
                list.Add(new SelectListItem()
                {
                    Text = topic.TopicName,
                    Value = topic.TopicId.ToString(),
                });
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<SelectListItem>> LevelSelectList()
        {
            var levels = await _levelRepository.GetAllAsync();
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var level in levels)
            {
                list.Add(new SelectListItem()
                {
                    Text = level.LevelName,
                    Value = level.LevelId.ToString(),
                });
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<SelectListItem> CourseStatusList()
        {
            var courseStatuses = Enum.GetValues(typeof(CourseStatus));
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var status in courseStatuses)
            {
                
                    list.Add(new SelectListItem()
                    {
                        Text = Enum.GetName(typeof(CourseStatus), status),
                        Value = Convert.ToInt32(status).ToString()
                    });
                

            }
            return list;
        }

        public static List<SelectListItem> LessonTypeList()
        {
            var lessonTypes = Enum.GetValues(typeof(MediaType));
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var type in lessonTypes)
            {
                list.Add(new SelectListItem()
                {
                    Text = Enum.GetName(typeof(MediaType), type),
                    Value = Convert.ToInt32(type).ToString()
                });
            }
            return list;
        }
    }
}
