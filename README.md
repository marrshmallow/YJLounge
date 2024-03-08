# YJ Lounge
팀 이름 : ? (정진솔, 황용연)

## 스케줄

2024\. 3\. 4\. 프로젝트 시작  
2024\. 3\. 8\. 프로젝트 1차 중간 발표  
2024\. 3\. 15\. 프로젝트 2차 중간 발표  
2024\. 3\. 17\. 발표 자료, 포트폴리오 완성  
2024\. 3\. 18\. 프로젝트 최종 발표일  

## 개발 환경

Unity 2022\.3\.9f1  

## 현재 과제 (연구/시도해볼 것들)

### 2024\. 3\. 4\.

- [x] 기본맵 생성  
- [x] 바닥 타일링 테스트  
- [x] ~~동영상 재생 유튜브 링크로 (유니티 내부 기능 있음) > 관련 기능 패키지 설치 완료~~  

### 2024\. 3\. 5\.  

- [X] 대화시스템 컷씬 기능 구현 (타임라인, 시네머신 등 이용)  

### 2024\. 3\. 6\.  

- [x] 기본맵 생성  
- [x] 바닥 타일링 테스트  
- [x] ~~동영상 재생 유튜브 링크로 (유니티 내부 기능 있음) > 관련 기능 패키지 설치 완료~~  

### 2024\. 3\. 5\.  

- [X] 대화시스템 컷씬 기능 구현 (타임라인, 시네머신 등 이용)  

### 2024\. 3\. 6\.  

- [ ] 부스 동선에 따른 정보 정리: 어떤 곳인가 -> 무엇을 배우는 곳인가 -> 우리 기수 포트폴리오  
- [ ] NPC 상호작용 스크립트(대본) 작성  
- [ ] NPC 상호작용 스크립트(대본) 작성  
- [ ] 위치 안내 선택지: 화면 상으로 입체 알려주기  
- [ ] 링크 UI [#1](https://www.youtube.com/watch?v=BRoInRutZIU) [#2](https://geukggom.tistory.com/150)  
- [ ] 링크 UI [#1](https://www.youtube.com/watch?v=BRoInRutZIU) [#2](https://geukggom.tistory.com/150)  

중요도가 떨어지는 작업  

- [ ] 어도비 일러스트레이터로 영진직업전문학교 로고 딴 뒤 3D화  
- [ ] 어도비로 최우수 훈련기관 마크 로고 딴 뒤 3D화  
- [ ] 조경 국가자격검정장에 설치된 테이블과 벤치 모델링  


![조경 국가자격검정장에 설치된 둥근 모양의 목재 테이블과 벤치](https://github.com/marrshmallow/YJLounge/blob/b65980864ec400c475b1ba64b48fb060ee83495c/Documentation/Images/image-1.png)  

## 모델링 시 주의사항

[모델링 치수와 유니티 단위 스케일](https://docs.unity3d.com/kr/2018.4/Manual/BestPracticeMakingBelievableVisuals1.html)

## 폴더에 관한 내용

### Assets > Scenes

Start: 시작 화면  
Main: 메인 화면

### 기타
 
Scripts: 스크립트 한데 모아놓는 곳. 복잡해지면 편의상 이 안에 따로 폴더를 만들 수도 있어요.  

## 필요한 기능에 대한 정보들

## 기타 개발상 편의 내용에 관한 정보들
[마크다운으로 Readme.md 파일을 만들어보자!](https://gist.github.com/ihoneymon/652be052a0727ad59601)  

## 개발일지

**2024\. 3\. 4\. 개발용 씬, 캐릭터 모델, 바닥 타일링 추가**  

![교육 과정은 총 11갈래로 나뉘어집니다. 과정 소개: IT, SW/전기공사/기계설계/디자인/용접/공조냉동/조경/가구, 공예/경영회계/패션봉제/인테리어, 건축](https://github.com/marrshmallow/YJLounge/blob/b65980864ec400c475b1ba64b48fb060ee83495c/Documentation/Images/image.png)  

**2024\. 3\. 5\.**  

* .gitingore 파일 갱신: .vscode 폴더와 .vsconfig 추가

* 유튜브 링크 임베드 해주는 패키지 설치 제거 완료  

>유튜브 측에서 이용 약관 상으로 유튜브 영상의 브라우저 외 재생을 금지했습니다.  
>(공식 앱, 공식 임베드, 공식 링크 외의 방법은 계약 위반 사항)  
>
>[WebView](https://github.com/gree/unity-webview)를 [사용하면](https://ljhyunstory.tistory.com/266) 가능한데 윈도우 빌드에서는 쓸 수 없어서  
>아무래도 링크를 사용하는 방법 밖에는 없는 것 같습니다.  

* Cinemachine 패키지 설치  

* NPC와 Player에 각각 NPC와 Player 태그를 추가  

* NPC와 Player에 애니메이터 추가  

* 타임라인 연출을 위한 준비 작업  

NPC에 타임라인 컴포넌트 추가. NPC(태그 있음) 주변을 Box Collider(Trigger)로 감싸서 플레이어(태그 있음)가 그 영역 안으로 들어왔을 때 상호작용 이벤트를 개시할 수 있는 상태로 만듦. 퀘스트가 있으면 NPC의 머리 위로 아이콘이 표시. 퀘스트가 없는 경우 아이콘이 없어도 해당 영역 안에서 상호작용할 경우 대화가 시작된다.  

>[!IMPORTANT]  
>플레이어의 상호작용에 관련한 코드를 어디에서 처리해야 하는지  
>각각의 이벤트는 타임라인에서 제어하는데 이것들을 종합적으로 하는 건 플레이어가 해줘야 할 것 같다  

* 작업: EventSystem의 InputSystem 인스펙터창에서 갱신  

* 대화 이벤트 발생 시 UI 기본 작업 시작.  

>[!IMPORTANT]  
>그냥 버튼 방식 아니고, 선택지에 표시되는 텍스트에 맞춰서 버튼의 이미지(반투명)의 너비가 변하고, 선택했을 때 스프라이트가 바뀌는 (테두리가 살짝 빛나는 듯한 효과) 연출 필요  

>[!IMPORTANT]  
>TextMeshPro의 Ellipsis 기능 썼는데, 이거 상호작용 키 누르면 다음 텍스트 표시해 주는 기능일까......?????????  

* 대화시스템 컷씬 기능 구현  

[Timeline 설명서](https://docs.unity3d.com/Packages/com.unity.timeline@1.7/manual/index.html)  

[Cinemachine과 Timeline](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineTimeline.html)  

이벤트별로 컷씬 연출을 다르게 해줄 수 있다는 점에서 편리하다.  
현재로써 이 작업을 애니메이터로 하는 게 더 빠른지는 알 수 없음.  

>[!IMPORTANT]  
>이 상태에서 대화창 텍스트를 다음으로 넘긴다거나 선택지 클릭이 되는지?  
>> 가능하다!  
>>  
>> ![이미지](https://github.com/marrshmallow/YJLounge/blob/b65980864ec400c475b1ba64b48fb060ee83495c/Documentation/Images/image-3.png)  
>>  
>> 선택지에 해당하는 게임오브젝트의 버튼 컴포넌트에서 On Click() 목록에 조작을 원하는 디렉터를 추가하고, (이 경우 'NPC' 게임 오브젝트) 해당 선택지를 클릭했을 때 재생될, '다음 컷씬' (별도 Timeline Asset)으로 점프하게 할 수 있다.  
  
  
![Warp Mode를 Hold로 해주면 마지막 장면에서 고정된 상태로 재생 시간이 끝나게 된다](https://github.com/marrshmallow/YJLounge/blob/b65980864ec400c475b1ba64b48fb060ee83495c/Documentation/Images/image-2.png)  

Warp Mode를 Hold로 해주면 마지막 장면에서 고정된 상태로 재생 시간이 끝나게 된다. 즉, None(기본값)일 경우 마지막 프레임 재생이 끝남과 동시에 원래 화면으로 돌아가게 된다.  

* 샘플 이벤트 컷씬 완성했습니다. (클릭하면 동영상 재생)  

[![샘플 이벤트 컷씬](https://github.com/marrshmallow/YJLounge/blob/b65980864ec400c475b1ba64b48fb060ee83495c/Documentation/Images/mqdefault.jpg)](https://youtu.be/QG0Gk4Sk6Zw?si=_KTAplaqxIqQWD6X)  

* 용연씨의 부스 모델링 영상 추가했습니다.

[![부스 모델링 초안](https://github.com/marrshmallow/YJLounge/blob/8feb48c76ec762dd67df44ae2be25a18415d9765/Documentation/Images/mqdefault1.jpg)](https://youtu.be/rIKlNbn00kM)  
