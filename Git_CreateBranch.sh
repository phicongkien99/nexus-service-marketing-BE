#!/bin/bash
read -p "Nhap ten nhanh muon tao : " branch
bash -c "git checkout develop"
git pull
bash -c "git checkout -b $branch"
bash -c "git push origin $branch:$branch"
git push --set-upstream origin $branch
read -p pause