using System;
using System.Collections.Generic;
using AthleticismWebAPI.DataAccess;
using AthleticismWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AthleticismWebAPI.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ReviewController : Controller
    {
        private readonly IReviewAccessProvider _reviewAccessProvider;
        public ReviewController(IReviewAccessProvider reviewAccessProvider)
        {
            _reviewAccessProvider = reviewAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return _reviewAccessProvider.GetReviewRecords();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Review review)
        {
            if (ModelState.IsValid)
            {                
                _reviewAccessProvider.AddReviewRecord(review);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Review Details(int id)
        {
            return _reviewAccessProvider.GetReviewSingleRecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewAccessProvider.UpdateReviewRecord(review);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _reviewAccessProvider.GetReviewSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _reviewAccessProvider.DeleteReviewRecord(id);
            return Ok();
        }
    }
}
