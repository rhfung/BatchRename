using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BatchRename
{
    class RenameEntry
    {
        private string m_CurrentName;
        private string m_Directory;
        private string m_OriginalName;

        public string NewName { get; set; }
        public string TemporaryName { get; set; }

        public RenameEntry(string FullFilename)
        {
            FileInfo f = new FileInfo(FullFilename);
            m_Directory = f.DirectoryName;
            m_OriginalName = f.Name;
            m_CurrentName = m_OriginalName;
        }

        public string OriginalName
        {
            get
            {
                return m_OriginalName;
            }
        }

        public string Directory
        {
            get
            {
                return m_Directory;
            }
        }

        public string CurrentName
        {
            get
            {
                return m_CurrentName;
            }
        }

        public bool CanRenameToTemp()
        {
            FileInfo tempFile = new FileInfo(Path.Combine(Directory, TemporaryName));
            FileInfo curFile = new FileInfo(Path.Combine(Directory, m_CurrentName));

            return !tempFile.Exists && curFile.Exists;
        }

        public bool RenameOldToTemp()
        {
            FileInfo tempFile = new FileInfo(Path.Combine(Directory, TemporaryName));
            // FileInfo newFile = new FileInfo(Path.Combine(Directory, NewName));

            if (!tempFile.Exists)
            {
                File.Move(Path.Combine(Directory, m_CurrentName),
                    Path.Combine(Directory, TemporaryName));

                m_CurrentName = TemporaryName;

                return true;
            }
            return false;
        }

        public bool CanRenameToNew()
        {
            //FileInfo tempFile = new FileInfo(Path.Combine(Directory, TemporaryName));
            FileInfo newFile = new FileInfo(Path.Combine(Directory, NewName));

            return !newFile.Exists;// && !newFile.Exists;
        }


        public bool RenameTempToNew()
        {
            FileInfo newFile = new FileInfo(Path.Combine(Directory, NewName));

            if (!newFile.Exists)
            {
                File.Move(Path.Combine(Directory, TemporaryName),
                    Path.Combine(Directory, NewName));

                m_CurrentName = NewName;

                return true;
            }

            return false;
        }

        public void Undo()
        {
            if (!m_CurrentName.Equals(OriginalName))
            {
                //if (m_CurrentName != null && m_CurrentName.Length > 0)
                //{
                    File.Move(Path.Combine(Directory, m_CurrentName),
                        Path.Combine(Directory, OriginalName));
                //}
                //else
                //{
                //    FileInfo newFile = new FileInfo(Path.Combine(Directory, NewName));
                //    FileInfo oldFile = new FileInfo(Path.Combine(Directory, OriginalName));

                //    if (newFile.Exists && !oldFile.Exists)
                //    {
                //        File.Move(Path.Combine(Directory, NewName),
                //            Path.Combine(Directory, OriginalName));
                //    }
                //}
            }
        }
    }



}
