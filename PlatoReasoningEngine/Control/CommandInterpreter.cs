using System;
using CommonLib;

namespace Control
{
    public class CommandInterpreter
    {


        public void Interpret(Command cmd)
        {

            switch (cmd.type)
            {
                case(CommandType.Add):
                    Add(cmd);
                    break;
                case(CommandType.Ask):
                    Ask(cmd);
                    break;
                case(CommandType.Debug):
                    Debug(cmd);
                    break;
                case(CommandType.How):
                    How(cmd);
                    break;
                case(CommandType.Why):
                    Why(cmd);
                    break;
                case(CommandType.WhyNot):
                    WhyNot(cmd);
                    break;
                default:
                    throw new ApplicationException("Unknown Command");
            }
        }

        private void Add(Command cmd)
        {

            throw new NotImplementedException();
        }


        private void Ask(Command cmd)
        {

            throw new NotImplementedException();
        }

        private void Debug(Command cmd)
        {

            throw new NotImplementedException();
        }

        private void How(Command cmd)
        {

            throw new NotImplementedException();
        }

        private void Why(Command cmd)
        {

            throw new NotImplementedException();
        }

        private void WhyNot(Command cmd)
        {

            throw new NotImplementedException();
        }



    }
}
