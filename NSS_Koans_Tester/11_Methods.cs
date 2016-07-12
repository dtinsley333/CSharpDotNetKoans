using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    public static class ExtensionMethods
    {
        public static string HelloWorld(this Koan koan)
        {
            return "Hello!";
        }

        public static string SayHello(this Koan koan, string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        public static string[] MethodWithVariableArguments(this Koan koan, params string[] names)
        {
            return names;
        }

        public static string SayHi(this String str)
        {
            return "Hi, " + str;
        }
    }

    [TestClass]
    public class Methods : Koan
    {
        [TestMethod]
        public void AboutMethodsExtensionMethodsShowUpInTheCurrentClass()
        {
            Assert.AreEqual(FILL_ME_IN, this.HelloWorld());
        }

        [TestMethod]
        public void AboutMethodsExtensionMethodsWithParameters()
        {
            Assert.AreEqual(FILL_ME_IN, this.SayHello("Cory"));
        }

        [TestMethod]
        public void AboutMethodsExtensionMethodsWithVariableParameters()
        {
            CollectionAssert.AreEqual(Fill_In, this.MethodWithVariableArguments("Cory", "Will", "Corey"));
        }

        //Extension methods can extend any class by referencing 
        //the name of the class they are extending. For example, 
        //we can "extend" the string class like so:

        [TestMethod]
        public void AboutMethodsExtendingCoreClasses()
        {
            Assert.AreEqual(FILL_ME_IN, "Cory".SayHi());
        }

        //Of course, any of the parameter things you can do with 
        //extension methods you can also do with local methods

        private string[] LocalMethodWithVariableParameters(params string[] names)
        {
            return names;
        }

        [TestMethod]
        public void AboutMethodsLocalMethodsWithVariableParams()
        {
            CollectionAssert.AreEqual(Fill_In, this.LocalMethodWithVariableParameters("Cory", "Will", "Corey"));
        }

        //Note how we called the method by saying "this.LocalMethodWithVariableParameters"
        //That isn't necessary for local methods

        [TestMethod]
        public void AboutMethodsLocalMethodsWithoutExplicitReceiver()
        {
            CollectionAssert.AreEqual(Fill_In, LocalMethodWithVariableParameters("Cory", "Will", "Corey"));
        }

        //But it is required for Extension Methods, since it needs
        //an instance variable. So this wouldn't work, giving a
        //compile-time error:
        //CollectionAssert.Equal(FILL_ME_IN, MethodWithVariableArguments("Cory", "Will", "Corey"));


        class InnerSecret
        {
            public static string Key() { return "Key"; }
            public string Secret() { return "Secret"; }
            protected string SuperSecret() { return "This is secret"; }
            private string SooperSeekrit() { return "No one will find me!"; }
        }

        class StateSecret : InnerSecret
        {
            public string InformationLeak() { return SuperSecret(); }
        }

        //Static methods don't require an instance of the object
        //in order to be called. 

        [TestMethod]
        public void AboutMethodsCallingStaticMethodsWithoutAnInstance()
        {
            Assert.AreEqual(FILL_ME_IN, InnerSecret.Key());
        }

        //In fact, you can't call it on an instance variable
        //of the object. So this wouldn't compile:
        //InnerSecret secret = new InnerSecret();
        //Assert.Equal(FILL_ME_IN, secret.Key());

        [TestMethod]
        public void AboutMethodsCallingPublicMethodsOnAnInstance()
        {
            InnerSecret secret = new InnerSecret();
            Assert.AreEqual(FILL_ME_IN, secret.Secret());
        }

        //Protected methods can only be called by a subclass
        //We're going to call the public method called
        //InformationLeak of the StateSecret class which returns
        //the value from the protected method SuperSecret

        [TestMethod]
        public void AboutMethodsCallingProtectedMethodsOnAnInstance()
        {
            StateSecret secret = new StateSecret();
            Assert.AreEqual(FILL_ME_IN, secret.InformationLeak());
        }

        //But, we can't call the private methods of InnerSecret
        //either through an instance, or through a subclass. It
        //just isn't available.

        //Ok, well, that isn't entirely true. Reflection can get
        //you just about anything, and though it's way out of scope
        //for this...

        [TestMethod]
        public void AboutMethodsSubvertPrivateMethods()
        {
            InnerSecret secret = new InnerSecret();
            string superSecretMessage = secret.GetType()
                .GetMethod("SooperSeekrit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(secret, null) as string;
            Assert.AreEqual(FILL_ME_IN, superSecretMessage);
        }

        //Up till now we've had explicit return types. It's also
        //possible to create methods which dynamically shift
        //the type based on the input. These are referred to
        //as generics

        public static T GiveMeBack<T>(T p1)
        {
            return p1;
        }

        [TestMethod]
        public void AboutMethodsCallingGenericMethods()
        {
            Assert.AreEqual(typeof(FillMeIn), GiveMeBack<int>(1).GetType());

            Assert.AreEqual(FILL_ME_IN, GiveMeBack<string>("Hi!"));
        }


    }
}
