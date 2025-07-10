using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjectBasedLeaning
{

    public interface TimeTracker
    {

        /// <summary>
        /// 出勤の時間を記録する。
        /// </summary>
        /// <param name="employeeId">従業員のID</param>
        /// <exception cref="InvalidOperationException">従業員がすでに仕事中の場合</exception>"
        void PunchIn(int employeeId);

        /// <summary>
        /// 退勤の時間を記録する。
        /// </summary>
        /// <param name="employeeId">従業員のID</param>
        /// <exception cref="InvalidOperationException">従業員が仕事中でない場合</exception>""
        void PunchOut(int employeeId);

        /// <summary>
        /// 仕事中かどうかを判定する。
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>仕事中の場合 true</returns>
        bool IsAtWork(int employeeId);

    }

    public class TimeTrackerModel : TimeTracker
    {

        private Company company = NullCompany.Instance;

        private Dictionary<DateTime, Dictionary<int, DateTime>> timestamp4PunchIn = new Dictionary<DateTime, Dictionary<int, DateTime>>();
        private Dictionary<DateTime, Dictionary<int, DateTime>> timestamp4PunchOut = new Dictionary<DateTime, Dictionary<int, DateTime>>();

        private Mode mode = Mode.PunchIn;

        private enum Mode
        {
            PunchIn, // default
            PunchOut
        };

        public TimeTrackerModel(Company company)
        {
            this.company = company.AddTimeTracker(this);
        }

        // キーの存在をチェックして初期化するメソッドを追加（修正箇所）
        private void EnsureTodayInitialized()
        {
            if (!timestamp4PunchIn.ContainsKey(DateTime.Today))
            {
                timestamp4PunchIn[DateTime.Today] = new Dictionary<int, DateTime>();
            }
            if (!timestamp4PunchOut.ContainsKey(DateTime.Today))
            {
                timestamp4PunchOut[DateTime.Today] = new Dictionary<int, DateTime>();
            }
        }

        public void PunchIn(int employeeId)
        {
            EnsureTodayInitialized(); // 修正：初期化を呼ぶ

            if (IsAtWork(employeeId))
            {
                throw new InvalidOperationException("Employee is already at work.");
            }

            // 修正：Addだと同じ日に複数の打刻があると例外になるので辞書に直接代入
            timestamp4PunchIn[DateTime.Today][employeeId] = DateTime.Now;
        }

        public void PunchOut(int employeeId)
        {
            EnsureTodayInitialized(); // 修正：初期化を呼ぶ

            if (!IsAtWork(employeeId))
            {
                throw new InvalidOperationException("Employee is not at work.");
            }

            // 修正：Addをやめて直接代入に変更
            timestamp4PunchOut[DateTime.Today][employeeId] = DateTime.Now;
        }

        private Dictionary<int, DateTime> CreateTimestamp(int employeeId)
        {
            Dictionary<int, DateTime> timestamp = new Dictionary<int, DateTime>();
            timestamp.Add(employeeId, DateTime.Now);

            return timestamp;
        }

        public bool IsAtWork(int employeeId)
        {
            // 修正：キーが存在するか確認してからアクセスするように変更
            if (!timestamp4PunchIn.ContainsKey(DateTime.Today))
                return false;
            if (!timestamp4PunchOut.ContainsKey(DateTime.Today))
                return timestamp4PunchIn[DateTime.Today].ContainsKey(employeeId);

            return timestamp4PunchIn[DateTime.Today].ContainsKey(employeeId)
                && !timestamp4PunchOut[DateTime.Today].ContainsKey(employeeId);
        }

    }

    public class NullTimeTracker : TimeTracker, NullObject
    {

        private static NullTimeTracker instance = new NullTimeTracker();

        private NullTimeTracker()
        {

        }

        public static TimeTracker Instance { get { return instance; } }

        public void PunchIn(int employeeId)
        {

        }

        public void PunchOut(int employeeId)
        {

        }

        public bool IsAtWork(int employeeId)
        {

            return false;

        }

    }

}
