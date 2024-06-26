﻿using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data.Repositories.Implementations;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Implementations
{
    public class CourseRequestService : ICourseRequestService
    {
        private readonly ILogger<CourseRequestService> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ICourseRequestRepository _courseRequestRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IUserService _userService;

        

        public CourseRequestService(ILogger<CourseRequestService> logger, IHttpContextAccessor httpContextAccessor, ICourseRequestRepository courseRequestRepository, ICourseRepository courseRepository, IUserService userService)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _courseRequestRepository = courseRequestRepository;
            _courseRepository = courseRepository;
            _userService = userService;
        }

        public async Task<List<CourseRequestListDTO>> GetAllCourseRequestsByInstructorIdAsync(int instructorId)
        {
            try
            {
                // current user

                var currentEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentEmail);

                if (currentUser == null)
                {
                    throw new Exception("Chưa đăng nhập");
                }

                // get all existing course
                var courses = await _courseRequestRepository.GetAllCourseRequestsByInstructorIdAsync(instructorId);

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var courseDictionary = new Dictionary<int, string>();
                foreach (var course in courses)
                {
                    var courseInfo = await _courseRequestRepository.GetCourseRequestNameAsync(course.CourseId);
                    courseDictionary.TryAdd(course.CourseId, courseInfo);
                }

                // map to DTO
                var requestDTO = new List<CourseRequestListDTO>();
                requestDTO = courses.Select(p => new CourseRequestListDTO
                {
                    CourseRequestId = p.CourseRequestId,
                    CourseId = p.CourseId,
                    CourseName = courseDictionary.ContainsKey(p.CourseId) ? courseDictionary[p.CourseId].ToString() : "",
                    InstructorId = instructorId,
                    InstructorName = currentUser.FullName,
                    Status = p.Status, 
                    RequestAt = p.RequestAt,
                    ResponseAt = p.ResponseAt,
                    IsDeleted = p.IsDeleted,
                    DeletedAt = p.DeletedAt
                }).ToList();

                return requestDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<List<CourseRequestListDTO>> GetAllCourseRequestsAsync()
        {
            try
            {
                

                // get all existing course
                var courses = await _courseRequestRepository.GetAllAsync();

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var courseDictionary = new Dictionary<int, string>();
                foreach (var course in courses)
                {
                    var courseInfo = await _courseRequestRepository.GetCourseRequestNameAsync(course.CourseId);
                    courseDictionary.TryAdd(course.CourseId, courseInfo);
                }

                // map to DTO
                var requestDTO = new List<CourseRequestListDTO>();
                requestDTO = courses.Select(p => new CourseRequestListDTO
                {
                    CourseRequestId = p.CourseRequestId,
                    CourseId = p.CourseId,
                    CourseName = courseDictionary.ContainsKey(p.CourseId) ? courseDictionary[p.CourseId].ToString() : "",
                    InstructorId = p.InstructorId,
                    Status = p.Status,
                    RequestAt = p.RequestAt,
                    ResponseAt = p.ResponseAt,
                    IsDeleted = p.IsDeleted,
                    DeletedAt = p.DeletedAt
                }).ToList();

                return requestDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<CourseRequestDetailDTO> GetCourseRequestByIdAsync(int id)
        {
            try
            {
                var courses = await _courseRequestRepository.GetAllAsync();

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var courseDictionary = new Dictionary<int, string>();
                foreach (var course in courses)
                {
                    var courseInfo = await _courseRequestRepository.GetCourseRequestNameAsync(course.CourseId);
                    courseDictionary.TryAdd(course.CourseId, courseInfo);
                }
                var request = await _courseRequestRepository.GetByIdAsync(id);
                if (request == null)
                {
                    throw new Exception();
                }


                var requestDTO = new CourseRequestDetailDTO()
                {
                    CourseRequestId = request.CourseRequestId,
                    CourseId = request.CourseId,
                    CourseName = courseDictionary.ContainsKey(request.CourseId) ? courseDictionary[request.CourseId].ToString() : "",
                    InstructorId = request.InstructorId,
                    Status = request.Status,
                    RequestAt = request.RequestAt,
                    ResponseAt = request.ResponseAt,
                };

                return requestDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public Task<CourseRequestCreateDTO> GetCourseRequestByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Status> CreateCourseRequestAsync(CourseRequestCreateDTO course)
        {
            try
            {
                // current user

                var currentEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentEmail);

                if (currentUser == null)
                {
                    throw new Exception("Chưa đăng nhập");
                }
                
                // map to DTO
                var requestCreateDTO = new CourseRequest()
                {
                    CourseId = course.CourseId,
                    InstructorId = currentUser.Id,
                    Status = course.Status,
                    RequestAt = course.RequestAt,
                    ResponseAt = course.ResponseAt,
                    IsDeleted = false,
                };


                var courseRequest = await _courseRequestRepository.CreateAsync(requestCreateDTO);
                if (courseRequest == 0)
                {
                    return Status.Fail;
                }


                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public Task<Status> DeleteCourseRequestAsync(CourseRequestDetailDTO course)
        {
            throw new NotImplementedException();
        }
        public async Task<Status> UpdateCourseRequestAsync(CourseRequestUpdateDTO data)
        {
            try
            {
                // current user

                var currentEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentEmail);

                if (currentUser == null)
                {
                    throw new Exception("Chưa đăng nhập");
                }

                var course = await _courseRequestRepository.GetByIdAsync(data.CourseRequestId);

                course.CourseId = data.CourseId;
                course.InstructorId = data.InstructorId;
                course.Status = data.Status;
                course.RequestAt = data.RequestAt;
                course.ResponseAt = data.ResponseAt;
                


                var courseRequest = await _courseRequestRepository.UpdateAsync(course);
                if (courseRequest == 0)
                {
                    return Status.Fail;
                }


                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }
    }
}
