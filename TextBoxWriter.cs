using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{

    internal class TextBoxWriter : TextWriter
    {
        private TextBox _textBox;
        public TextBoxWriter(TextBox textbox) {
            _textBox = textbox;
        }

        public override void Write(char value)
        {
            // Обновляем TextBox через Invoke, чтобы избежать ошибок потоков
            if (_textBox.InvokeRequired)
            {
                _textBox.Invoke((Action)(() => _textBox.AppendText(value.ToString())));
            }
            else
            {
                _textBox.AppendText(value.ToString());
            }
        }

        public override void Write(string value)
        {
            // Обновляем TextBox через Invoke
            if (_textBox.InvokeRequired)
            {
                _textBox.Invoke((Action)(() => _textBox.AppendText(value)));
            }
            else
            {
                _textBox.AppendText(value);
            }
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}
