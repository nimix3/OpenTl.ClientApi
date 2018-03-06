﻿namespace OpenTl.ClientApi.MtProto.Layers.Messages.Adapters
{
    using DotNetty.Transport.Channels;

    using log4net;

    using Newtonsoft.Json;

    using OpenTl.Common.IoC;
    using OpenTl.Schema;

    [SingleInstance(typeof(IMessageHandler))]
    internal class MsgDetailedInfoHandler : SimpleChannelInboundHandler<TMsgDetailedInfo>,
                                            IMessageHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MsgDetailedInfoHandler));

        public int Order { get; } = 100;

        protected override void ChannelRead0(IChannelHandlerContext ctx, TMsgDetailedInfo msg)
        {
            if (Log.IsDebugEnabled)
            {
                var jMessages = JsonConvert.SerializeObject(msg);
                Log.Debug($"Receiving MsgDetailedInfo message: {jMessages}");
            }
        }
    }
}