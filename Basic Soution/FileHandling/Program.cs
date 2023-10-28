// See https://aka.ms/new-console-template for more information
using FileHandling;

FileOperation fileOperation = new FileOperation();
fileOperation.CreateFile();
fileOperation.WriteData();
fileOperation.ReadData();
fileOperation.CopyMoveFile();
fileOperation.DeleteFile();
fileOperation.FileProperties();
