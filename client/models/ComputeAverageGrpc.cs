// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ComputeAverage.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ComputeAverage {
  public static partial class ComputeAverageService
  {
    static readonly string __ServiceName = "ComputeAverage.ComputeAverageService";

    static readonly grpc::Marshaller<global::ComputeAverage.ComputeAverageRequest> __Marshaller_ComputeAverage_ComputeAverageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ComputeAverage.ComputeAverageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ComputeAverage.ComputeAverageResponse> __Marshaller_ComputeAverage_ComputeAverageResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ComputeAverage.ComputeAverageResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ComputeAverage.ComputeAverageRequest, global::ComputeAverage.ComputeAverageResponse> __Method_ComputeAverage = new grpc::Method<global::ComputeAverage.ComputeAverageRequest, global::ComputeAverage.ComputeAverageResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ComputeAverage",
        __Marshaller_ComputeAverage_ComputeAverageRequest,
        __Marshaller_ComputeAverage_ComputeAverageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ComputeAverage.ComputeAverageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ComputeAverageService</summary>
    [grpc::BindServiceMethod(typeof(ComputeAverageService), "BindService")]
    public abstract partial class ComputeAverageServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ComputeAverage.ComputeAverageResponse> ComputeAverage(grpc::IAsyncStreamReader<global::ComputeAverage.ComputeAverageRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ComputeAverageService</summary>
    public partial class ComputeAverageServiceClient : grpc::ClientBase<ComputeAverageServiceClient>
    {
      /// <summary>Creates a new client for ComputeAverageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ComputeAverageServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ComputeAverageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ComputeAverageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ComputeAverageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ComputeAverageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncClientStreamingCall<global::ComputeAverage.ComputeAverageRequest, global::ComputeAverage.ComputeAverageResponse> ComputeAverage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeAverage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::ComputeAverage.ComputeAverageRequest, global::ComputeAverage.ComputeAverageResponse> ComputeAverage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ComputeAverage, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ComputeAverageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ComputeAverageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ComputeAverageServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ComputeAverage, serviceImpl.ComputeAverage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ComputeAverageServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ComputeAverage, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::ComputeAverage.ComputeAverageRequest, global::ComputeAverage.ComputeAverageResponse>(serviceImpl.ComputeAverage));
    }

  }
}
#endregion
