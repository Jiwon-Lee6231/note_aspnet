using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Note.BLL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Note.MVC.Controllers
{
    public class MemoController : Controller
    {
        private readonly MemoBll _memoBll;

        public MemoController(MemoBll memoBll)
        {
            _memoBll = memoBll;
        }

        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            var list = _memoBll.GetMemoList();

            return View(list);
        }

        /// <summary>
        /// 게시글 상세 출력
        /// </summary>
        /// <param name="memoNo"></param>
        /// <returns></returns>
        public IActionResult Detail(int memoNo)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            var memo = _memoBll.GetMemo(memoNo);

            return View(memo);
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        /// <summary>
        /// 게시물 추가 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Memo model)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            model.UserNo = int.Parse(HttpContext.Session.GetInt32("USER_LOGIN_KEY").ToString());

            if (ModelState.IsValid)
            {
                var success = _memoBll.PostMemo(model);
                if (success) return Redirect("Index");
                
                ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
            }

            return View(model);
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
