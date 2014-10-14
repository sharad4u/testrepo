using System;
using System.Runtime.Serialization;

namespace LibGit2Sharp
{
    /// <summary>
    /// The exception that is thrown when a operation requiring an existing
    /// branch is performed against an unborn branch.
    /// </summary>
    [Serializable]
    public class UnbornBranchException : LibGit2SharpException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnbornBranchException"/> class.
        /// </summary>
        public UnbornBranchException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnbornBranchException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public UnbornBranchException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnbornBranchException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public UnbornBranchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnbornBranchException"/> class with a serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected UnbornBranchException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
/* This is extra164 */
