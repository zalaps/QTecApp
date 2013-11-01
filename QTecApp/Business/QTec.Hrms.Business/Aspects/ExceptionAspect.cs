﻿namespace QTec.Hrms.Business.Aspects
{
    using System;

    using NLog;

    using PostSharp.Aspects;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ExceptionAspect : OnExceptionAspect
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Method executed <b>after</b> the body of methods to which this aspect is applied,
        /// in case that the method resulted with an exception (i.e., in a <c>catch</c> block).
        /// </summary>
        /// <param name="args">Advice arguments.</param>
        public override void OnException(MethodExecutionArgs args)
        {
            var logMessage = string.Format("Error was thrown in method {0} . The error message is {1}", args.Method.Name, args.Exception.InnerException.Message);
            logger.Error(logMessage);
            args.ReturnValue = null;
            args.FlowBehavior=FlowBehavior.Return;
            base.OnException(args);
        }
    }
}
