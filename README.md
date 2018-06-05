# survival_shooter  
----------------------
![screenshot_1](https://user-images.githubusercontent.com/38284288/40973181-4121be6a-68fe-11e8-912f-aea3bd6d6b5c.png)    
**screenshot1 게임 처음실행시**  
unity홈페이지의 asset store에서 필요한 asset들을 import하여 플레이어와 배경 그리고 충돌물들을 배치하였으며  
플레이어는 사용자의 wasd키를 입력받아 위 왼쪽 아래 오른쪽 으로 이동할 수 있다.  
그리고 또 마우스의 왼쪽 키를 입력받아 마우스 커서가 가리키는 위치로 총알을 발사한다.  
![screenshot_2](https://user-images.githubusercontent.com/38284288/40973330-dc3d8b18-68fe-11e8-8127-b6bdecc58171.png)  
**screenshot2 적을 총알로 맞추었을 때**  
적들은 3가지 spawn position을 가지며 해당하는 spawn position에서  
일정시간 마다 적prefab들이 scene에 나오게 된다.  
적의 capsule collider에 총알이 충돌했음을 인식하면 적의 hp가 줄어들고  
충분한 크기의 피해를 입으면 적은 죽는 애니메이션을 실행한뒤 바닥으로 가라앉고  
스크립트에 의해 일정시간 후 사라진다.  




unity project
