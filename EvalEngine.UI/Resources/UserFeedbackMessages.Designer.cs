﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvalEngine.UI.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class UserFeedbackMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserFeedbackMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EvalEngine.UI.Resources.UserFeedbackMessages", typeof(UserFeedbackMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have already confirmed your email address... please log in.|FAILURE.
        /// </summary>
        public static string AlreadyConfirmed {
            get {
                return ResourceManager.GetString("AlreadyConfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {0},
        ///
        ///Your password has been changed. 
        ///Questions? Contact Info@EvaluationEngine.org.
        ///
        ///Thank you for participating in Evaluation Engine..
        /// </summary>
        public static string BodyConfirmPasswordReset {
            get {
                return ResourceManager.GetString("BodyConfirmPasswordReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {0},
        ///
        ///An Evaluation Engine account has been created for you. Please click the link below to create a password.
        ///
        ///{1}
        ///
        ///Questions? Contact Info@EvaluationEngine.org..
        /// </summary>
        public static string BodyNewAccount {
            get {
                return ResourceManager.GetString("BodyNewAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {0},
        ///
        ///Please click the link below to change your password. This link will expire in {1} hours. 
        ///
        ///{2}
        ///
        ///Questions? Contact Info@EvaluationEngine.org.
        ///
        ///Thank you for participating in Evaluation Engine..
        /// </summary>
        public static string BodyPasswordResetRequest {
            get {
                return ResourceManager.GetString("BodyPasswordResetRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select at least one state.|FAILURE.
        /// </summary>
        public static string ChooseAtLeastOneState {
            get {
                return ResourceManager.GetString("ChooseAtLeastOneState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A password reset link has been sent to your email address. Please check your email and follow the instructions to reset your password.|SUCCESS.
        /// </summary>
        public static string ConfirmPasswordResetRequest {
            get {
                return ResourceManager.GetString("ConfirmPasswordResetRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has expired.  Please change it.|FAILURE.
        /// </summary>
        public static string ExpiredPassword {
            get {
                return ResourceManager.GetString("ExpiredPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This reset password URL has expired. Please log in or click Reset Password again.|FAILURE.
        /// </summary>
        public static string ExpiredPasswordResetUrl {
            get {
                return ResourceManager.GetString("ExpiredPasswordResetUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error with the data you entered.|FAILURE.
        /// </summary>
        public static string FaultyClientData {
            get {
                return ResourceManager.GetString("FaultyClientData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The token provided is not valid.  Please try clicking the link in the email again.|FAILURE.
        /// </summary>
        public static string FaultyPasswordResetToken {
            get {
                return ResourceManager.GetString("FaultyPasswordResetToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please upload a file. It could be possible the one you submitted has no content..
        /// </summary>
        public static string FileNotSubmitted {
            get {
                return ResourceManager.GetString("FileNotSubmitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder was successfully deleted.|SUCCESS.
        /// </summary>
        public static string FolderDeletedSuccessfully {
            get {
                return ResourceManager.GetString("FolderDeletedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email or password provided is incorrect.|FAILURE.
        /// </summary>
        public static string InvalidCredentials {
            get {
                return ResourceManager.GetString("InvalidCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your account has been locked. Please wait 10 minutes before trying to log in again.|FAILURE.
        /// </summary>
        public static string LockedAccount {
            get {
                return ResourceManager.GetString("LockedAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not authorized to use this section of the site.|FAILURE.
        /// </summary>
        public static string NotAuthorizedInSiteSection {
            get {
                return ResourceManager.GetString("NotAuthorizedInSiteSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords may only be reset once a day.|FAILURE.
        /// </summary>
        public static string OnlyOnePasswordResetPerDay {
            get {
                return ResourceManager.GetString("OnlyOnePasswordResetPerDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please consider changing your password soon. It will expire in {0} day(s).|FAILURE.
        /// </summary>
        public static string PasswordAboutToExpire {
            get {
                return ResourceManager.GetString("PasswordAboutToExpire", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have already used that password in the recent past. Please pick another.|FAILURE.
        /// </summary>
        public static string PasswordInHistory {
            get {
                return ResourceManager.GetString("PasswordInHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password passed additional validation checks..
        /// </summary>
        public static string PasswordIsValid {
            get {
                return ResourceManager.GetString("PasswordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error with the data you entered.|FAILURE.
        /// </summary>
        public static string PasswordResetFail {
            get {
                return ResourceManager.GetString("PasswordResetFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user account is not valid. Please try clicking the link in your email again.|FAILURE.
        /// </summary>
        public static string PasswordResetNotValid {
            get {
                return ResourceManager.GetString("PasswordResetNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new password is too similar to the old password.|FAILURE.
        /// </summary>
        public static string PasswordsTooSimilar {
            get {
                return ResourceManager.GetString("PasswordsTooSimilar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current password is incorrect or the new password is invalid.|FAILURE.
        /// </summary>
        public static string PasswordUpdateFail {
            get {
                return ResourceManager.GetString("PasswordUpdateFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password was successfully updated.|SUCCESS.
        /// </summary>
        public static string PasswordUpdateSuccess {
            get {
                return ResourceManager.GetString("PasswordUpdateSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong!  We&apos;ll look into the problem.|FAILURE.
        /// </summary>
        public static string SomethingWentWrong {
            get {
                return ResourceManager.GetString("SomethingWentWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please upload a file or paste information into the box..
        /// </summary>
        public static string StudentIdUploadError {
            get {
                return ResourceManager.GetString("StudentIdUploadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation Engine—Password was successfully reset.
        /// </summary>
        public static string SubjectConfirmPasswordReset {
            get {
                return ResourceManager.GetString("SubjectConfirmPasswordReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation Engine—Account Created.
        /// </summary>
        public static string SubjectNewAccount {
            get {
                return ResourceManager.GetString("SubjectNewAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation Engine—Password Change Request.
        /// </summary>
        public static string SubjectPasswordResetRequest {
            get {
                return ResourceManager.GetString("SubjectPasswordResetRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have successfully updated your password.|SUCCESS.
        /// </summary>
        public static string SuccessNewAccountVerification {
            get {
                return ResourceManager.GetString("SuccessNewAccountVerification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The account for the user was created successfully.  The user should receive a confirmation email soon.|SUCCESS.
        /// </summary>
        public static string UserAccountCreatedSuccessfully {
            get {
                return ResourceManager.GetString("UserAccountCreatedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We encountered an error while creating this account.  Please ensure you entered all the fields, and that the user you are trying to create does not already exist in the system.|FAILURE.
        /// </summary>
        public static string UserAddError {
            get {
                return ResourceManager.GetString("UserAddError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user could not be removed.|FAILURE.
        /// </summary>
        public static string UserDeleteFail {
            get {
                return ResourceManager.GetString("UserDeleteFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user was successfully removed.|SUCCESS.
        /// </summary>
        public static string UserDeleteSuccess {
            get {
                return ResourceManager.GetString("UserDeleteSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user account could not be updated.|FAILURE.
        /// </summary>
        public static string UserUpdateFail {
            get {
                return ResourceManager.GetString("UserUpdateFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another user is using that email address.|FAILURE.
        /// </summary>
        public static string UserUpdateFailEmailAddressInUse {
            get {
                return ResourceManager.GetString("UserUpdateFailEmailAddressInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You entered incorrectly one or more fields.|FAILURE.
        /// </summary>
        public static string UserUpdateFailInvalidData {
            get {
                return ResourceManager.GetString("UserUpdateFailInvalidData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We don&apos;t know exactly how you would like to edit this user.|FAILRUE.
        /// </summary>
        public static string UserUpdateFailNoAction {
            get {
                return ResourceManager.GetString("UserUpdateFailNoAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user you attempted to edit does not exist.|FAILURE.
        /// </summary>
        public static string UserUpdateFailUserDoesNotExist {
            get {
                return ResourceManager.GetString("UserUpdateFailUserDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user account was successfully updated.|SUCCESS.
        /// </summary>
        public static string UserUpdateSuccess {
            get {
                return ResourceManager.GetString("UserUpdateSuccess", resourceCulture);
            }
        }
    }
}
