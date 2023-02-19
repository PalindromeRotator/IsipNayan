using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScreens : MonoBehaviour
{
    public void LetsBegin()
    {
        SceneManager.LoadScene("EnterUsername");
    }
    public void playGame1()
    {
        SceneManager.LoadScene("Categories");
    }
    // QUARTERSTOMODULE //
    public void Quarter1()
    {
        SceneManager.LoadScene("Quarter1");
    }
    public void Quarter2()
    {
        SceneManager.LoadScene("Quarter2");
    }
    public void Quarter3()
    {
        SceneManager.LoadScene("Quarter3");
    }
    public void Quarter4()
    {
        SceneManager.LoadScene("Quarter4");
    }
    // QUARTER#1_LESSON //
    public void L_QuarterToSecondPage()
    {
        SceneManager.LoadScene("Quarterr1");
    }
    public void L_QuarterToFirstPage()
    {
        SceneManager.LoadScene("Quarter1");
    }
    //------------------------------------------------------------------------//
    // QUARTER#2_LESSON //
    public void L2_QuarterToSecondPage()
    {
        SceneManager.LoadScene("Quarterr2");
    }
    public void L2_QuarterToFirstPage()
    {
        SceneManager.LoadScene("Quarter2");
    }
    //------------------------------------------------------------------------//
    // QUARTER#3_LESSON //
    public void L3_QuarterToSecondPage()
    {
        SceneManager.LoadScene("Quarterr3");
    }
    public void L3_QuarterToFirstPage()
    {
        SceneManager.LoadScene("Quarter3");
    }
    //------------------------------------------------------------------------//
    // QUARTER#4_LESSON //
    public void L4_QuarterToSecondPage()
    {
        SceneManager.LoadScene("Quarterr4");
    }
    public void L4_QuarterToFirstPage()
    {
        SceneManager.LoadScene("Quarter4");
    }
    //------------------------------------------------------------------------//
    public void Home()
    {
        SceneManager.LoadScene("Home");
    }
    public void LessonCoverage()
    {
        SceneManager.LoadScene("LessonCoverage");
    }
    // LESSONS //
    public void Categories()
    {
        SceneManager.LoadScene("Categories");
    }
    // VIDEOS //
    public void Video()
    {
        SceneManager.LoadScene("1stVideoMaterials1");
    }
    public void VideoNext()
    {
        SceneManager.LoadScene("2ndVideoMaterials");
    }
    public void VideoBack()
    {
        SceneManager.LoadScene("1stVideoMaterials1");
    }
    // CALCULATOR //
    public void Calculator()
    {
        SceneManager.LoadScene("Calculator");
    }
    // TOTAL SCORE EXIT //
    public void Exit()
    {
        SceneManager.LoadScene("GameScene");
    }
    //PRACTICE//
    public void PracticeToQuarter()
    {
        SceneManager.LoadScene("PracticeQuarter");
    }
    //QUARTERTOMODULE//
    public void Quarter1ToModule()
    {
        SceneManager.LoadScene("Assessment1");
    }
    public void Quarter2ToModule()
    {
        SceneManager.LoadScene("Q2Assessment1");
    }
    public void Quarter3ToModule()
    {
        SceneManager.LoadScene("Q3Assessment1");
    }
    public void Quarter4ToModule()
    {
        SceneManager.LoadScene("Q4Assessment1");
    }
    public void ModuleToQuarter()
    {
        SceneManager.LoadScene("PracticeQuarter");
    }
    //AnswerKeyToQuarters//
    public void AnswerKeyToQuarters()
    {
        SceneManager.LoadScene("AnswerKeyQuarter");
    }
    //GameSceneToCategories
    public void GameSceneToCategories()
    {
        SceneManager.LoadScene("Categories");
    }
    public void PracticeToCategories()
    {
        SceneManager.LoadScene("Categories");
    }

    public void AnswerkeyToCategories()
    {
        SceneManager.LoadScene("Categories");
    }
    // Video Materials Quarter //
    public void CategoriesToVideoQuarter()
    {
        SceneManager.LoadScene("VideoQuarter");
    }
    public void VideoQuarter()
    {
        SceneManager.LoadScene("VideoQuarter");
    }
    public void Q1ToQ1Video()
    {
        SceneManager.LoadScene("Q1VideoMaterials");
    }
    public void Q2ToQ2Video()
    {
        SceneManager.LoadScene("Q2VideoMaterials");
    }
    public void Q3ToQ3Video()
    {
        SceneManager.LoadScene("Q3VideoMaterials");
    }
    public void Q4ToQ4Video()
    {
        SceneManager.LoadScene("Q4VideoMaterials");
    }
    // Playing Video //
    public void Q1Video1()
    {
        SceneManager.LoadScene("PlayingVideo");
    }
    public void Q1VideoMaterials()
    {
        SceneManager.LoadScene("Q1VideoMaterials");
    }
    // Game Quarter //
    public void ScoreToGameQuarter()
    {
        SceneManager.LoadScene("GameQuarter");
    }
    public void CategoriesToGameQuarter()
    {
        SceneManager.LoadScene("GameQuarter");
    }
    //Quarter 1 Game Quarter //
    public void Game()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void AnswerScene1()
    {
        SceneManager.LoadScene("Q1_Answer#1");
    }
    public void Question1()
    {
        SceneManager.LoadScene("Q1_Question#1");
    }
    public void AnswerScene2()
    {
        SceneManager.LoadScene("Q1_Answer#2");
    }
    public void Question2()
    {
        SceneManager.LoadScene("Q1_Question#2");
    }
    public void Score1()
    {
        SceneManager.LoadScene("Score");
    }
    //Module 1//
    public void ModuleToQuarterLesson()
    {
        SceneManager.LoadScene("Quarter1");
    }
    public void ModuleToQuarter2Lesson()
    {
        SceneManager.LoadScene("Quarter2");
    }
    public void ModuleToQuarter3Lesson()
    {
        SceneManager.LoadScene("Quarter3");
    }
    public void ModuleToQuarter4Lesson()
    {
        SceneManager.LoadScene("Quarter4");
    }
    //GAME//PLAY//TO QUESTION
    public void Quarter1ToPlay()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void QuestionTab()
    {
        SceneManager.LoadScene("QuestionTab");
    }
    public void AnswerTab()
    {
        SceneManager.LoadScene("AnswerTab");
    }
    public void ScoreTab()
    {
        SceneManager.LoadScene("ScoreTab");
    }

    public void VideoPlaying1()
    {
        SceneManager.LoadScene("#1VideoPlaying");
    }
    public void VideoPlaying2()
    {
        SceneManager.LoadScene("#2VideoPlaying");
    }
    public void VideoPlaying3()
    {
        SceneManager.LoadScene("#3VideoPlaying");
    }
    public void VideoPlaying4()
    {
        SceneManager.LoadScene("#4VideoPlaying");
    }
    public void VideoPlaying5()
    {
        SceneManager.LoadScene("#5VideoPlaying");
    }
    public void VideoPlaying6()
    {
        SceneManager.LoadScene("#6VideoPlaying");
    }
    public void VideoPlaying7()
    {
        SceneManager.LoadScene("#7VideoPlaying");
    }
    public void VideoPlaying8()
    {
        SceneManager.LoadScene("#8VideoPlaying");
    }
    public void VideoPlaying9()
    {
        SceneManager.LoadScene("#9VideoPlaying");
    }

    public void VideoPlaying1_2()
    {
        SceneManager.LoadScene("#1VideoPlayingQ2");
    }
    public void VideoPlaying2_2()
    {
        SceneManager.LoadScene("#2VideoPlayingQ2");
    }
    public void VideoPlaying3_2()
    {
        SceneManager.LoadScene("#3VideoPlayingQ2");
    }
    public void VideoPlaying4_2()
    {
        SceneManager.LoadScene("#4VideoPlayingQ2");
    }
    public void VideoPlaying5_2()
    {
        SceneManager.LoadScene("#5VideoPlayingQ2");
    }
    public void VideoPlaying6_2()
    {
        SceneManager.LoadScene("#6VideoPlayingQ2");
    }
    public void VideoPlaying7_2()
    {
        SceneManager.LoadScene("#7VideoPlayingQ2");
    }
    public void VideoPlaying8_2()
    {
        SceneManager.LoadScene("#8VideoPlayingQ2");
    }
    public void VideoPlaying9_2()
    {
        SceneManager.LoadScene("#9VideoPlayingQ2");
    }

    public void VideoPlaying1_3()
    {
        SceneManager.LoadScene("#1VideoPlayingQ3");
    }
    public void VideoPlaying2_3()
    {
        SceneManager.LoadScene("#2VideoPlayingQ3");
    }
    public void VideoPlaying3_3()
    {
        SceneManager.LoadScene("#3VideoPlayingQ3");
    }
    public void VideoPlaying4_3()
    {
        SceneManager.LoadScene("#4VideoPlayingQ3");
    }
    public void VideoPlaying5_3()
    {
        SceneManager.LoadScene("#5VideoPlayingQ3");
    }
    public void VideoPlaying6_3()
    {
        SceneManager.LoadScene("#6VideoPlayingQ3");
    }
    public void VideoPlaying7_3()
    {
        SceneManager.LoadScene("#7VideoPlayingQ3");
    }
    public void VideoPlaying8_3()
    {
        SceneManager.LoadScene("#8VideoPlayingQ3");
    }
    public void VideoPlaying9_3()
    {
        SceneManager.LoadScene("#9VideoPlayingQ3");
    }
    //--------------------------------------------------------------------------------------//

}
