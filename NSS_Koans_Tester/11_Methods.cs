using System;
using Xunit;
using NSS_Koans;
using System.Globalization;

namespace NSS_Koans_Tester
{
    public static class ExtensionMethods
    {

        public static string HelloWorld(this String str)
        {
            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            return str;
        }

        public static string SayHello(this string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        public static string[] MethodWithVariableArguments(this string[] names)
        {
            foreach(var customer in names)
            {
                System.Console.WriteLine($"Customer = {names}");
            }
            
            return names;
        }

        public static string SayHi(this string str)
        {
            return "Hi, " + str;
        }
    }

    public class Methods
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        public Koan koan=new Koan();
        [Fact]
        public void AboutMethodsExtensionMethodsShowUpInTheCurrentClass()
        {
            string hello = "hello world";
            hello = hello.HelloWorld();
            Assert.Equal(FILL_ME_IN, hello);
        }

        [Fact]
        public void AboutMethodsExtensionMethodsWithParameters()
        {
            string name = "Cory";
            name = name.SayHello();

            Assert.Equal(FILL_ME_IN, name);
        }

        [Fact]
        public void AboutMethodsExtensionMethodsWithVariableParameters()
        {
            string[] names= { "Cory", "Will", "Corey" };
            names = names.MethodWithVariableArguments();

            Assert.Equal(FILL_ME_IN, names);
        }

        //Extension methods can extend any class by referencing 
        //the name of the class they are extending. For example, 
        //we can "extend" the string class like so:

        [Fact]
        public void AboutMethodsExtendingCoreClasses()
        {
            Assert.Equal(FILL_ME_IN, "Cory".SayHi());
        }

        //Of course, any of the parameter things you can do with 
        //extension methods you can also do with local methods

        private string[] LocalMethodWithVariableParameters(params string[] names)
        {
            return names;
        }

        [Fact]
        public void AboutMethodsLocalMethodsWithVariableParams()
        {
            Assert.Equal(FILL_ME_IN, this.LocalMethodWithVariableParameters("Cory", "Will", "Corey"));
        }

        //Note how we called the method by saying "this.LocalMethodWithVariableParameters"
        //That isn't necessary for local methods

        [Fact]
        public void AboutMethodsLocalMethodsWithoutExplicitReceiver()
        {
            Assert.Equal(FILL_ME_IN, LocalMethodWithVariableParameters("Cory", "Will", "Corey"));
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

        [Fact]
        public void AboutMethodsCallingStaticMethodsWithoutAnInstance()
        {
            Assert.Equal(FILL_ME_IN, InnerSecret.Key());
        }

        //In fact, you can't call it on an instance variable
        //of the object. So this wouldn't compile:
        //InnerSecret secret = new InnerSecret();
        //Assert.Equal(FILL_ME_IN, secret.Key());

        [Fact]
        public void AboutMethodsCallingPublicMethodsOnAnInstance()
        {
            InnerSecret secret = new InnerSecret();
            Assert.Equal(FILL_ME_IN, secret.Secret());
        }

        //Protected methods can only be called by a subclass
        //We're going to call the public method called
        //InformationLeak of the StateSecret class which returns
        //the value from the protected method SuperSecret

        [Fact]
        public void AboutMethodsCallingProtectedMethodsOnAnInstance()
        {
            StateSecret secret = new StateSecret();
            Assert.Equal(FILL_ME_IN, secret.InformationLeak());
        }

        /* But, we can't call the private methods of InnerSecret
        either through an instance, or through a subclass. It
        just isn't available.

        Ok, well, that isn't entirely true. Reflection can get
        you just about anything, and though it's way out of scope
        for this...*/

        [Fact]
        public void AboutMethodsSubvertPrivateMethods()
        {
            InnerSecret secret = new InnerSecret();
            string superSecretMessage = secret.GetType()
                .GetMethod("SooperSeekrit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(secret, null) as string;
            Assert.Equal(FILL_ME_IN, superSecretMessage);
        }

        //Up till now we've had explicit return types. It's also
        //possible to create methods which dynamically shift
        //the type based on the input. These are referred to
        //as generics

        public static T GiveMeBack<T>(T p1)
        {
            return p1;
        }

        [Fact]
        public void AboutMethodsCallingGenericMethods()
        {
            Assert.Equal(typeof(FillMeIn), GiveMeBack<int>(1).GetType());

            Assert.Equal(FILL_ME_IN, GiveMeBack<string>("Hi!"));
        }


    }
}
