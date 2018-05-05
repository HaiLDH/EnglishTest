using EnglishTest.Model.Models;
using EnglishTest.Service.Services;
using EnglishTest.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishTest.Web.Areas.Admin.Controllers
{
    public class AdminQuestionController : Controller
    {
        private QuestionService _questionService;
        private AnswerService _answerService;
        private LevelService _levelService;
        private TestKitService _testKitService;

        public AdminQuestionController(QuestionService questionService,
                                        AnswerService answerService,
                                        LevelService levelService,
                                        TestKitService testKitService)
        {
            _questionService = questionService;
            _answerService = answerService;
            _levelService = levelService;
            _testKitService = testKitService;
        }

        // GET: Admin/AdminQuestion
        public ActionResult Index()
        {
            var fullQuestions = new FullQuestion()
            {
                Questions = _questionService.GetAll(),
                Answers = _answerService.GetAll()
            };

            ViewBag.Levels = _levelService.GetAll();
            ViewBag.Testkits = _testKitService.GetAll();

            return View("~/Areas/Admin/Views/AdminQuestion/Index.cshtml", fullQuestions);
        }

        public ActionResult AddOrEditQuestion(int? questionId)
        {
            var editQuestion = new EditQuestion()
            {
                Question = questionId == null ? new Question() : _questionService.GetSingleById(questionId ?? default(int)),
                Answers = _answerService.GetMulti(a => a.QuestionID == questionId),
                Levels = _levelService.GetAll(),
                TestKits = _testKitService.GetAll().OrderByDescending(x => x.CreateDate)
            };

            return View("~/Areas/Admin/Views/AdminQuestion/AddOrEditQuestion.cshtml", editQuestion);
        }


        //List Question
        public JsonResult GetListQuestion()
        {
            var fullQuestions = new FullQuestion()
            {
                Questions = _questionService.GetAll(),
                Answers = _answerService.GetAll()
            };

            return Json(_questionService.GetAll(), JsonRequestBehavior.AllowGet);
        }

        //Add Question use ajax
        public JsonResult AddQuestion(Question question)
        {
            question.CreateDate = DateTime.Now;
            question.UpdateDate = DateTime.Now;

            return Json(_questionService.Add(question), JsonRequestBehavior.AllowGet);
        }
    }
}