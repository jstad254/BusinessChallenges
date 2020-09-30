using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Repo
{
    public class BadgeRepository
    {
        Badges badges = new Badges();
        public Dictionary<int, string> BadgeDictionary = new Dictionary<int badgeID, string badgeName>();
        private List<Badges> _badgeList = new List<Badges>();
        // Create... method to create new badge
        public void CreateBadge(Badges badgeToCreate)
        {
            _badgeList.Add(badgeToCreate);
        }
        // Read... method to list all badges with the door(s) they access
        public List<Badges> GetBadges()
        {
            return _badgeList;
        }
        // Update... method to update doors on badge
        public /*bool*/void UpdateCurrentBadge(int badgeID, Badges newBadgeUpdate)
        {
            Badges currentBadges = GetByBadgeID(badgeID);
            if (currentBadges != null)
            {
                currentBadges.doorList = newBadgeUpdate.doorList;
            }
            else
            {
                return false;
            }
        }
        // Delete... method to delete all doors on badge
        public /*bool*/void RemoveAllDoorsFromBadge(int badgeID)
        {
            Badges data = GetByBadgeID(badgeID);
            if (data == null)
            {
                return false;
            }

            if (badgeID = _badgeList.BadgeID)
            {
                _badgeList.Remove(doorList);
            }
        }
        // Helper... method to call up badge by ID
        private Badges GetByBadgeID(int badgeID)
        {
            foreach (Badges data in _badgeList)
            {
                if (data.BadgeID == badgeID)
                {
                    return data;
                }
            }
            return null;
        }
    }
}
