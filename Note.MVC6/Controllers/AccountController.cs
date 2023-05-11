using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Note.BLL;
using Note.Model;
using Note.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Note.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserBll _userBll;

        public AccountController(UserBll userBll)
        {
            _userBll = userBll;
        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 로그인 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userBll.GetUser(model.UserId, model.UserPassword);

                if (user != null)
                {
                    // 로그인 성공
                    HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);

                    return RedirectToAction("LoginSuccess", "Home");
                }

                // 로그인 실패
                ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
            }

            return View(model);
        }

        /// <summary>
        /// 로그아웃
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");

            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                _userBll.AddUser(model);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
