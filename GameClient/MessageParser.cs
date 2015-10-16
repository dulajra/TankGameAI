﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    class MessageParser
    {
        private ParserNode rootNode;
        private static MessageParser mInstance = null;
        public static MessageParser Instance
        {
            get
            {
                if(mInstance == null)
                {
                    mInstance = new MessageParser();
                }
                return mInstance;
            }
        }

        public MessageParser()
        {
            //setup chain of responsibility here
            rootNode = null;
            rootNode = new ParserNode(Messages.JoinAcceptanceMessage.JoinAcceptanceMessageParser.Instance);
            
        }

        public static bool ValidateMessageFooter(String message)
        {
            String shortMessage = message.Trim();
            if(shortMessage.EndsWith("#"))
            {
                return true;
            }
            return false;
        }
        
        /*
        Returns parsed message. If parser fails, return null
        */
        public Messages.ServerMessage Parse(String message)
        {
            if (rootNode == null)
                return null;

            /*
            Validate message format
            */
            if(ValidateMessageFooter(message))
            {
                string[] sections = Tokenizer.TokenizeSections(message);
                return rootNode.Parse(sections);
            }
            else
            {
                /*
                Parser fails. Message footer is missing
                */
                return null;
            }

            
        }

        private class ParserNode
        {
            private Messages.ServerMessage.ServerMessageParser parser;
            private ParserNode nextNode = null;

            public ParserNode(Messages.ServerMessage.ServerMessageParser parser)
            {
                this.parser = parser;
            }

            public Messages.ServerMessage.ServerMessageParser Parser
            {
                get { return parser; }
                set { parser = value; }
            }

            public ParserNode NextNode
            {
                get { return nextNode; }
                set { nextNode = value; }
            }
            /*
            if this parsenode can parse, then parse and return. Otherwise, pass to next node in chain
            */
            public Messages.ServerMessage Parse(string[] sections)
            {
                if (this.parser == null)
                    return null;
                Messages.ServerMessage result = this.parser.TryParse(sections);
                if(result == null)
                {
                    if (this.nextNode == null)
                        return null;
                    return this.nextNode.Parse(sections);
                }
                return result;
            }

        }
    }
}
