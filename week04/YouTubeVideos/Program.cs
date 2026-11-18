using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to Programming", "Joshua Uyinosagbon Anthony", 900);
        video1.SetCommentSection("bayo", "funny");
        video1.SetCommentSection("tola","lovely");
        video1.SetCommentSection("kunle", "amazing");
        video1.GetVideo();

        Video video2 = new Video("Introduction to Basic Science", "Omojewhw Collins", 1000);
        video2.SetCommentSection("AdeTola", "Wow, i never believed it was this easy. Thankyou Sir");
        video2.SetCommentSection("Ola","Omg, It was really helpful");
        video2.SetCommentSection("Alamo Alamu", "Sir, make another video explaining the endocrine System");
        video2.SetCommentSection("Henry","I am so loving this. I will give you a follow");
        video2.SetCommentSection("Olanlokun", "this is exactly what i needed");
        video2.GetVideo();

        Video video3 = new Video("Introduction to Economics", "Henry Emmanuel Obedience", 6300);
        video3.SetCommentSection("Enegwero", "On my way to becoming a capitalist. lol");
        video3.SetCommentSection("Adetona","hmmmmm");
        video3.SetCommentSection("daneil","As a small business owner i always implement this in my business");
        video3.SetCommentSection("Ope", "Noted. Strong point");
        video3.GetVideo();

        Video video4 = new Video("How to win at chess", "AeJay22", 900);
        video4.SetCommentSection("Kunle", "the scandinavian defense is the way to go");
        video4.SetCommentSection("caleb","i am 500Elo rated");
        video4.SetCommentSection("gift", "I love this video");
        video4.GetVideo();
    }
}