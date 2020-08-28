namespace InjectionCoreProject
{
    // Required namespaces
    using Ninject;
    using System;

    /// <summary>
    /// Contains extensions for Ninject
    /// </summary>
    public static class KernelExtensions
    {
        public static IK Construct<IK>(this IK K) where IK: IKernel
        {
            // Check if K is null
            if (K == null) throw new ArgumentNullException();

            // All kernel bindings should be done here
            K.Bind<ApplicationViewModel>().ToConstant(
                                                        new ApplicationViewModel() );

            // Return the constructed Kernel
            return K;
        }

    }
}
