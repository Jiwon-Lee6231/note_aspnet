using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.BLL
{
    public class NoticeBll
    {
        private readonly INoticeDal _noticeDal;

        public NoticeBll(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }

        /// <summary>
        /// 공지사항 리스트 출력
        /// </summary>
        /// <returns></returns>
        public List<Notice> GetNoticeList()
        {
            return _noticeDal.GetNoticeList();
        }

        /// <summary>
        /// 공지사항 상세 출력
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public Notice GetNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();

            return _noticeDal.GetNotice(noticeNo);
        }

        /// <summary>
        /// 공지사항 등록
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool PostNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException();

            return _noticeDal.PostNotice(notice);
        }

        /// <summary>
        /// 공지사항 수정
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool UpdateNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException();

            return _noticeDal.UpdateNotice(notice);
        }

        /// <summary>
        /// 공지사항 삭제
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public bool DeleteNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();

            return _noticeDal.DeleteNotice(noticeNo);
        }
    }
}
