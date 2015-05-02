using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Untappd.Net.Responses.Actions;

namespace Untappd.Net.UnitTests.Responses.Actions
{
    [TestFixture]
    public class TestSimpleActions
    {
        [Test]
        public void TestFriends()
        {
            var accept = new AcceptFriend("targetid");
            Assert.IsNotNullOrEmpty(accept.RequestMethod.ToString());
            Assert.IsTrue(accept.EndPoint.Contains("targetid"));
            Assert.IsNotNull(accept.BodyParameters);

            var add = new AddFriend("targetid");
            Assert.IsNotNullOrEmpty(add.RequestMethod.ToString());
            Assert.IsTrue(add.EndPoint.Contains("targetid"));
            Assert.IsNotNull(add.BodyParameters);

            var toast = new ToastUntoast("targetid");
            Assert.IsNotNullOrEmpty(toast.RequestMethod.ToString());
            Assert.IsTrue(toast.EndPoint.Contains("targetid"));
            Assert.IsNotNull(toast.BodyParameters);

            var remove = new RemoveFriend("targetid");
            Assert.IsNotNullOrEmpty(remove.RequestMethod.ToString());
            Assert.IsTrue(remove.EndPoint.Contains("targetid"));
            Assert.IsNotNull(remove.BodyParameters);

            var removeWish = new RemoveFromWishList(1);
            Assert.IsNotNullOrEmpty(removeWish.RequestMethod.ToString());
            Assert.IsNotNullOrEmpty(removeWish.EndPoint);
            Assert.AreEqual(removeWish.BodyParameters["bid"], 1);


            var addWish = new AddToWishList(1);
            Assert.IsNotNullOrEmpty(addWish.RequestMethod.ToString());
            Assert.IsNotNullOrEmpty(addWish.EndPoint);
            Assert.AreEqual(addWish.BodyParameters["bid"], 1);

            var comment = new AddComment("checkin", "shout");
            Assert.IsNotNullOrEmpty(comment.RequestMethod.ToString());
            Assert.IsTrue(comment.EndPoint.Contains("checkin"));
            Assert.AreEqual(comment.BodyParameters["shout"], "shout");
        }

        [Test]
        public void TestPendingFriends()
        {
            var pending = new PendingFriends();
            Assert.IsNotNullOrEmpty(pending.RequestMethod.ToString());
            Assert.IsNotNullOrEmpty(pending.EndPoint);
            Assert.IsNotNull(pending.BodyParameters);
            Assert.IsFalse(pending.BodyParameters.ContainsKey("limit"));
            pending.Limit = 1;
            Assert.IsTrue(pending.BodyParameters.ContainsKey("limit"));
            Assert.IsFalse(pending.BodyParameters.ContainsKey("offset"));
            pending.Offset = 1;
            Assert.IsTrue(pending.BodyParameters.ContainsKey("offset"));
        }

        [Test]
        public void TestArgumentNull()
        {
            Assert.Throws<ArgumentNullException>(() => { new AcceptFriend(string.Empty); });
            Assert.Throws<ArgumentNullException>(() => { new AddFriend(string.Empty); });
            Assert.Throws<ArgumentNullException>(() => { new RemoveFriend(string.Empty); });
            Assert.Throws<ArgumentNullException>(() => { new ToastUntoast(string.Empty); });
            Assert.Throws<ArgumentNullException>(() => { new AddComment(string.Empty, "ds"); });
            Assert.Throws<ArgumentNullException>(() => { new AddComment("ds", string.Empty); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { new AddComment("ds", new String('d', 141)); });
        }
    }
}
