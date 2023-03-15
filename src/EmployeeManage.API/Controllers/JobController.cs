using EmployeeManage.Common.DTOs.Job;
using EmployeeManage.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManage.API.Controllers;

[ApiController]
[Route("/job")]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateJob(JobCreate jobCreate)
    {
        var id = await _jobService.CreateJobAsync(jobCreate);
        return Ok(id);
    }

    [HttpPut]
    [Route("update")]
    public async Task<IActionResult> UpdateJob(JobUpdate jobUpdate)
    {
        await _jobService.UpdateJobAsync(jobUpdate);
        return Ok();
    }
    
    [HttpDelete]
    [Route("delete")]
    public async Task<IActionResult> DeleteAddress(JobDelete jobDelete)
    {
        await _jobService.DeleteJobAsync(jobDelete);
        return Ok();
    }

    [HttpGet]
    [Route("get/{id}")]
    public async Task<IActionResult> GetJob(int id)
    {
        var job = await _jobService.GetJobAsync(id);
        return Ok(job);
    }
    
    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetJobs()
    {
        var jobs = await _jobService.GetJobsAsync();
        return Ok(jobs);
    }
}