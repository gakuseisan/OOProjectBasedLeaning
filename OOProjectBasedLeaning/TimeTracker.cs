using System;
using System.Collections.Generic;

namespace OOProjectBasedLeaning
{
    public interface TimeTracker
    {
        void PunchIn(int employeeId);
        void PunchOut(int employeeId);
        bool IsAtWork(int employeeId);
    }

    public class TimeTrackerModel : TimeTracker
    {
        private Company company = NullCompany.Instance;

        private Dictionary<DateTime, Dictionary<int, DateTime>> timestamp4PunchIn = new();
        private Dictionary<DateTime, Dictionary<int, DateTime>> timestamp4PunchOut = new();

        private Dictionary<int, bool> atWorkStatus = new(); // ★ 状態を保持する辞書

        public TimeTrackerModel(Company company)
        {
            this.company = company.AddTimeTracker(this);
        }

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
            EnsureTodayInitialized();

            if (IsAtWork(employeeId))
            {
                throw new InvalidOperationException("すでに出勤しています。");
            }

            timestamp4PunchIn[DateTime.Today][employeeId] = DateTime.Now;
            atWorkStatus[employeeId] = true;
        }

        public void PunchOut(int employeeId)
        {
            EnsureTodayInitialized();

            if (!IsAtWork(employeeId))
            {
                throw new InvalidOperationException("現在出勤していません。");
            }

            timestamp4PunchOut[DateTime.Today][employeeId] = DateTime.Now;
            atWorkStatus[employeeId] = false;
        }

        public bool IsAtWork(int employeeId)
        {
            return atWorkStatus.ContainsKey(employeeId) && atWorkStatus[employeeId];
        }

        // 出勤時刻を取得（オプション）
        public DateTime? GetPunchInTime(int employeeId)
        {
            if (timestamp4PunchIn.TryGetValue(DateTime.Today, out var dayRecords))
            {
                if (dayRecords.TryGetValue(employeeId, out var time))
                {
                    return time;
                }
            }
            return null;
        }

        // 退勤時刻を取得（オプション）
        public DateTime? GetPunchOutTime(int employeeId)
        {
            if (timestamp4PunchOut.TryGetValue(DateTime.Today, out var dayRecords))
            {
                if (dayRecords.TryGetValue(employeeId, out var time))
                {
                    return time;
                }
            }
            return null;
        }
    }

    public class NullTimeTracker : TimeTracker, NullObject
    {
        private static readonly NullTimeTracker instance = new();

        private NullTimeTracker() { }

        public static TimeTracker Instance => instance;

        public void PunchIn(int employeeId) { }

        public void PunchOut(int employeeId) { }

        public bool IsAtWork(int employeeId) => false;
    }
}
