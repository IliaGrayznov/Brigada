package com.company;
import  java.io.*;
import  java.net.*;

public class Startthread implements  Runnable  {
    private Socket  connectionSocket;
    private String req;
    private String res;
    public  Startthread( Socket  connectionSocket){
        this.connectionSocket=connectionSocket;
    }
    public void run()  {
        try {
            System.out.println("Client has connected");
            BufferedReader inFromClient = new BufferedReader(new InputStreamReader(connectionSocket.getInputStream()));
            DataOutputStream outToClient = new DataOutputStream(connectionSocket.getOutputStream());
            req = inFromClient.readLine();
            System.out.println("Filename has been received");
            String filename = "F:\\учеба\\5 семестр\\ИС\\лр3\\Server\\Files\\" + req;
            File f = new File(filename);
            if (f.exists()) {
                res = "File has been find" + "\n";
                outToClient.writeBytes(res);
                int r = 0;
                FileInputStream fromFile1 = new FileInputStream(filename);
                while (r != -1) {
                    r = fromFile1.read();
                    outToClient.writeUTF(r + "");
                }
            } else {
                System.out.println("Calling other server");
                CallService c = new CallService();
                if (c.ask(req).equals("Not find")) {
                    res = "Not find" + "\n";
                    outToClient.writeBytes(res);
                } else {
                    res = "File has been find" + "\n";
                    outToClient.writeBytes(res);
                    int r = 0;
                    FileInputStream fromFile1 = new FileInputStream("F:\\учеба\\5 семестр\\ИС\\лр3\\Server\\Files\\downloadedFile");
                    while (r != -1) {
                        r = fromFile1.read();
                        outToClient.writeUTF(r + "");
                    }
                }
            }
            System.out.println("Information has been sent");
        }
        catch ( Exception e) {
        }
    }
}
