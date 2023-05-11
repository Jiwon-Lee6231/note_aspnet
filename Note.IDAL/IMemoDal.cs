using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.IDAL
{
    public interface IMemoDal
    {
        /// <summary>
        /// 게시판 리스트 출력
        /// </summary>
        /// <returns></returns>
        List<Memo> GetMemoList();

        /// <summary>
        /// 게시글 상세 출력
        /// </summary>
        /// <param name="memoNo"></param>
        /// <returns></returns>
        Memo GetMemo(int memoNo);

        /// <summary>
        /// 게시글 등록
        /// </summary>
        /// <param name="memo"></param>
        /// <returns></returns>
        bool PostMemo(Memo memo);

        /// <summary>
        /// 게시글 수정
        /// </summary>
        /// <param name="memo"></param>
        /// <returns></returns>
        bool UpdateMemo(Memo memo);

        /// <summary>
        /// 게시글 삭제
        /// </summary>
        /// <param name="memoNo"></param>
        /// <returns></returns>
        bool DeleteMemo(int memoNo);
    }
}
