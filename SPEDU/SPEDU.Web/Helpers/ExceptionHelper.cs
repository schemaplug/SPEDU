﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPEDU.Web.ViewModels;

namespace SPEDU.Web.Helpers
{
    public static class ExceptionHelper
    {
        public static string ExceptionMessageFormat(Exception ex)
        {
            string message = "Error: There was a problem while processing your request: " + ex.Message;

            if (ex.InnerException != null)
            {
                Exception inner = ex.InnerException;
                if (inner is System.Data.Common.DbException)
                    message = "Database is currently experiencing problems. " + inner.Message;
                //else if (inner is System.Data.UpdateException)
                //    message = "Datebase is currently updating problem.";
                //else if (inner is System.Data.EntityException)
                //    message = "Entity is problem.";
                else if (inner is NullReferenceException)
                    message = "There are one or more required fields that are missing.";
                else if (inner is ArgumentException)
                {
                    string paramName = ((ArgumentException)inner).ParamName;
                    message = string.Concat("The ", paramName, " value is illegal.");
                }
                else if (inner is ApplicationException)
                    message = "Exception in application" + inner.Message;
                else
                    message = inner.Message;

            }

            return message;
        }

        public static string ExceptionMessageForNullObject()
        {
            string message = "Requested object could not found.";

            return message;
        }

        public static ErrorViewModel ExceptionErrorMessageFormat(Exception ex)
        {
            var errorViewModel = new ErrorViewModel();

            string message = "Error: There was a problem while processing your request: " + ex.Message;

            if (ex.InnerException != null)
            {
                Exception inner = ex.InnerException;
                if (inner is System.Data.Common.DbException)
                    message = "Database is currently experiencing problems. " + inner.Message;
                //else if (inner is System.Data.UpdateException)
                //    message = "Datebase is currently updating problem.";
                //else if (inner is System.Data.EntityException)
                //    message = "Entity is problem.";
                else if (inner is NullReferenceException)
                    message = "There are one or more required fields that are missing.";
                else if (inner is ArgumentException)
                {
                    string paramName = ((ArgumentException)inner).ParamName;
                    message = string.Concat("The ", paramName, " value is illegal.");
                }
                else if (inner is ApplicationException)
                    message = "Exception in application" + inner.Message;
                else
                    message = inner.Message;

            }

            errorViewModel.ErrorType = "error";
            errorViewModel.ErrorMessage = message;

            return errorViewModel;
        }

        public static ErrorViewModel ExceptionErrorMessageForNullObject()
        {
            var errorViewModel = new ErrorViewModel();

            string message = "Requested object could not found.";

            errorViewModel.ErrorType = "warn";
            errorViewModel.ErrorMessage = message;

            return errorViewModel;
        }

        public static ErrorViewModel ExceptionErrorMessageForCommon()
        {
            var errorViewModel = new ErrorViewModel();

            string message = "Oops! Exception in application.";

            errorViewModel.ErrorType = "info";
            errorViewModel.ErrorMessage = message;

            return errorViewModel;
        }

        public static string ModelStateErrorFormat(System.Web.Mvc.ModelStateDictionary modelStateDictionary)
        {
            string message = @"<div class='mess'>";

            foreach (var modelStateValues in modelStateDictionary.Values)
            {
                if (modelStateValues.Errors.Any())
                {
                    foreach (var modelError in modelStateValues.Errors)
                    {
                        message += "<p>";
                        message += modelError.ErrorMessage;
                        message += "</p>";
                    }
                }
            }

            message += "</div>";

            return message;
        }

    }
}