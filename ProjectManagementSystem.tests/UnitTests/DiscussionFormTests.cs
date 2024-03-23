using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class DiscussionFormTests
    {
        [Fact]
        public void CanAddPostToDiscussionForm()
        {
            // Arrange
            var form = new DiscussionThread();
            var post = new DiscussionPost { Id = 1, Message = "Hello World", Author = "User1" };

            // Act
            form.AddPost(post);

            // Assert
            Assert.Contains(post, form.Posts);
        }

        [Fact]
        public void CanRemovePostFromDiscussionForm()
        {
            // Arrange
            var form = new DiscussionThread();
            var post = new DiscussionPost { Id = 1, Message = "Hello World", Author = "User1" };
            form.AddPost(post);

            // Act
            bool result = form.RemovePost(post);

            // Assert
            Assert.True(result);
            Assert.DoesNotContain(post, form.Posts);
        }

        [Fact]
        public void CanGetPostById()
        {
            // Arrange
            var form = new DiscussionThread();
            var post = new DiscussionPost { Id = 1, Message = "Hello World", Author = "User1" };
            form.AddPost(post);

            // Act
            var retrievedPost = form.GetPost(post.Id);

            // Assert
            Assert.Equal(post, retrievedPost);
        }
    }

    public class PostTests
    {
        [Fact]
        public void CanEditPostMessage()
        {
            // Arrange
            var post = new DiscussionPost { Id = 1, Message = "Original Message", Author = "User1" };
            var newMessage = "Edited Message";

            // Act
            post.EditMessage(newMessage);

            // Assert
            Assert.Equal(newMessage, post.Message);
            Assert.True(DateTime.UtcNow >= post.Timestamp); // Assuming the test runs fast enough
        }
    }
}
